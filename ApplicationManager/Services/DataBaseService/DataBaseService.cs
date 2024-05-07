using ApplicationManager.Helpers;
using MyLib;
using System.Xml.Linq;

namespace ApplicationManager.Services.DataBaseService;

public class DataBaseService
{
    private readonly SQL remoteSql;
    private readonly LogFile? remoteLog = null;
    private readonly InternetDocumentDataBaseService _internetDocumentDataBaseService;
    public DataBaseService()
    {
        _internetDocumentDataBaseService = new InternetDocumentDataBaseService();
        (remoteSql, remoteLog) = DBHelper.InitRemove();
    }

    public void CreateDataTable()
    {
        var query = @"
            IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'novaposhta')
            BEGIN
                EXEC('CREATE SCHEMA novaposhta')
            END

            IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'apiKeys' AND schema_id = SCHEMA_ID('novaposhta'))
            BEGIN
                CREATE TABLE novaposhta.apiKeys(
                    PharmacyCode VARCHAR(255) PRIMARY KEY,
                    PharmacyName VARCHAR(255),
                    ApiKey VARCHAR(255)
                );
            END;";

        remoteSql.Execute(query, remoteLog);
    }
    public async Task<bool> UpdateApiKey(string newApiKey)
    {
        try
        {
            using var data = await _internetDocumentDataBaseService.GetApteka();

            var pharmacyCode = data.Rows[0]["code"].ToString();
            var pharmacyName = data.Rows[0]["name"].ToString();
            var checkQuery = $"SELECT ApiKey FROM novaposhta.apiKeys WHERE PharmacyCode = '{pharmacyCode}'";
            var result = remoteSql.SelectQuery(checkQuery, remoteLog, "InternetSaleApteka");

            if (result is { Rows.Count: > 0 })
            {
                var existingApiKey = result.Rows[0]["ApiKey"].ToString();
                if (existingApiKey == newApiKey || string.IsNullOrWhiteSpace(newApiKey)) return false;
                var updateQuery = $"UPDATE novaposhta.apiKeys SET ApiKey = '{newApiKey}', PharmacyName = '{pharmacyName}' WHERE PharmacyCode = '{pharmacyCode}'";
                remoteSql.Execute(updateQuery, remoteLog);
            }
            else
            {
                var insertQuery = $"INSERT INTO novaposhta.apiKeys (PharmacyCode, PharmacyName, ApiKey) VALUES ('{pharmacyCode}', '{pharmacyName}', '{newApiKey}')";
                remoteSql.Execute(insertQuery, remoteLog);
            }
            return true;
        }
        catch 
        {
            return false;
        }
    }


}
