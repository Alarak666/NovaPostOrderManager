using ApplicationManager.Helpers;
using Core.Constants.DefaultValues;
using Core.CustomException;
using MyLib;
using Serilog;
using System.Data;
using System.Diagnostics;

namespace ApplicationManager.Services.DataBaseService;

public class OrderPostDataBaseService
{
    private readonly SQL sql;
    private readonly LogFile? log = null;

    public OrderPostDataBaseService()
    {
        (sql, log) = DBHelper.Init();
    }

    public async Task<DataTable> GetOrders()
    {
        var query = @$"
                SELECT
                  oht.[id] AS [{CoreDefaultValues.OrderTablentkiId}],
                  oht.[code] AS [{CoreDefaultValues.OrderTablentkiCode}],   
                  oht.[customerPhone] AS [{CoreDefaultValues.OrderTablentkiCustomerPhone}],
                  oht.[status_1c] AS [{CoreDefaultValues.OrderTablentkiStatus}],
                  oht.[Approve] AS [{CoreDefaultValues.OrderTablentkiApprove}],
                  oht.[TTN_1C] AS [{CoreDefaultValues.OrderTablentkiTTN1C}],
                  ort.[FullName] AS [{CoreDefaultValues.OrderTablentkiFullName}],
                  ort.[CityReceiver] AS [{CoreDefaultValues.OrderTablentkiCityReceiver}],
                  ort.[IDWhs] AS [{CoreDefaultValues.OrderTablentkiIDWhs}],
                  ort.[ReceiverWhs] AS [{CoreDefaultValues.OrderTablentkiReceiverWhs}],
                  d.SP4944 AS [{CoreDefaultValues.OrderTablentkiCost}],
                  j.docno AS [{CoreDefaultValues.OrderTablentkiDocumentNumber}]
            FROM
                [InternetSaleApteka].[dbo].[OrderHeader_Tabletki] oht
            LEFT JOIN
                [InternetSaleApteka].[dbo].[OrderDelivery_Tabletki] ort ON oht.id = ort.ID
	        LEFT JOIN
                [base1c].[dbo].[DH4923] d with (nolock) ON d.SP4933 = oht.[id]
            LEFT JOIN
                [base1c].[dbo].[_1SJOURN] j with (nolock) ON j.IDDOC = d.IDDOC
            WHERE
                oht.delivery = 1
                AND oht.status_1c = 6 
                AND dateTimeCreated > DATEADD(D, -2, GETDATE())
                AND oht.TTN IS NULL
	            AND ISNULL(oht.Cancelled, 0) != 1;";

        return sql.SelectQuery(query, log, "InternetSaleApteka");
    }

    public async Task<bool> UpdateOrderTabletki(string id, string intDocNumber)
    {
        var query = @$"
              UPDATE [InternetSaleApteka].[dbo].[OrderHeader_Tabletki]
                 SET [TTN_1C] ='{intDocNumber}'
               WHERE [id] = '{id}' AND (LEN([TTN_1C]) = 0 OR [TTN_1C] IS NULL);";
        sql.Execute(query, log);

        var queryUpdate = $@"
                UPDATE 
                I set SP5697 = '{intDocNumber}' from base1c..DH4923 I
                left join base1c..SC4910 K on K.id = SP4995
                where SP4933 = '{id}' and k.code = '00002'";
        return sql.Execute(queryUpdate, log);

    }
}