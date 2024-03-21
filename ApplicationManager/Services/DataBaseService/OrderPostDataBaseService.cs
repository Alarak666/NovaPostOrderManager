﻿using ApplicationManager.Helpers;
using Core.Constants.DefaultValues;
using Core.CustomException;
using MyLib;
using Serilog;
using System.Data;
using System.Diagnostics;

namespace ApplicationManager.Services.DataBaseService;

public class OrderPostDataBaseService
{
    private readonly SQL remoteSql;
    private readonly LogFile? log = null;

    public OrderPostDataBaseService()
    {
        (remoteSql, log) = DBHelper.Init();
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

        return remoteSql.SelectQuery(query, log, "InternetSaleApteka");
    }

    public async Task<bool> UpdateOrderTabletki(string id, string intDocNumber)
    {
        var query = @$"
              UPDATE [InternetSaleApteka].[dbo].[OrderHeader_Tabletki]
                 SET [TTN_1C] ='{intDocNumber}'
               WHERE [id] = '{id}' AND (LEN([TTN_1C]) = 0 OR [TTN_1C] IS NULL);";
        return remoteSql.Execute(query, log);
    }

    public async Task PrinterDocument(string? documentNumber)
    {
        string apiKey = CoreDefaultValues.ApiKey;

        if (string.IsNullOrWhiteSpace(documentNumber) || string.IsNullOrWhiteSpace(apiKey))
            throw new CustomException("Не вдалось роздрукувати: відсутній номер документа або API ключ.");

        string url = $"https://my.novaposhta.ua/orders/printMarking85x85/orders[]/{documentNumber}/type/pdf8/apiKey/{apiKey}";

        try
        {

            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "PrintError");
            throw new CustomException("Не вдалось роздрукувати");
        }
    }
}