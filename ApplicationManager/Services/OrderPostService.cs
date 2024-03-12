using ApplicationManager.Helpers;
using Core.Constants;
using Core.Constants.Enums;
using Core.Dto.InternetDocuments.CreateInternetDocument;
using Core.Dto.InternetDocuments.CreateInternetDocument.Request;
using Core.Dto.InternetDocuments.CreateInternetDocument.Response;
using Core.Dto.Settlements.GetWarehouses;
using Core.Dto.Settlements.GetWarehouses.Request;
using Core.Dto.Settlements.GetWarehouses.Response;
using Core.Interface;
using MyLib;
using System.Data;

namespace ApplicationManager.Services;

public class OrderPostService : IOrderPostService
{
    private readonly SQL remoteSql;
    private readonly HttpClientProvider _httpClientProvider = new();

    public OrderPostService()
    {
        remoteSql = DBHelper.Init().sql;
    }

    public async Task<DataTable> GetOrders()
    {
        var query = @"
                SELECT
                oht.[id],
	            oht.[code], 
                oht.[customerPhone],
	            oht.[status_1c], 
                oht.[Approve],
	            oht.[TTN_1C],
                ort.[FullName], 
	            ort.[CityReceiver],
	            ort.[IDWhs], 
                ort.[ReceiverWhs], 
	            d.SP4944 Cost
            FROM 
                [InternetSaleApteka].[dbo].[OrderHeader_Tabletki] oht
            LEFT JOIN 
                [InternetSaleApteka].[dbo].[OrderDelivery_Tabletki] ort ON oht.id = ort.ID
	            LEFT JOIN [base1c].[dbo].[DH4923] d with (nolock) on d.SP4933 = oht.[id]
            WHERE 
                oht.delivery = 1 
                AND oht.status_1c = 6 
                AND dateTimeCreated > DATEADD(D, -2, GETDATE())
                --AND oht.TTN IS NULL
	            --AND ISNULL(oht.Cancelled, 0) != 1;";

        return remoteSql.SelectQuery(query, new LogFile("Log"), "InternetSaleApteka");
    }
}