using Core.Dto;
using MyLib;
using System.Data;
using Core.Interface;

namespace Application.Services;

public class OrderPostService : IOrderPostService
{
    private readonly string _connectionString;
    private static SQL remoteSql;
    string sqlRemoteServer = "W-KV-SPORT1-104";
    string sqlRemoteUser = "sa";
    string sqlRemotePass = "Inter0000";
    string sqlRemoteDBName = "InternetSaleApteka";
    public OrderPostService()
    {
        remoteSql = new SQL($"Data Source={sqlRemoteServer};User ID={sqlRemoteUser};Password={sqlRemotePass};Database={sqlRemoteDBName};", "RiverMall - Admin");

    }

    public async Task<ICollection<OrderModel>> GetOrders()
    {
        var query = @"
                SELECT oht.[id], oht.[code], oht.[dateTimeCreated], 
                oht.[customerPhone], oht.[createDateTime], oht.[status_1c], 
                oht.[Approve], oht.[delivery], oht.[TTN_1C], oht.[TTN], 
                ort.[DeliveryServiceName], ort.[DeliveryServiceAlias], 
                ort.[FullName], ort.[CityReceiver], ort.[IDWhs], 
                ort.[ReceiverWhs]
                FROM [InternetSaleApteka].[dbo].[OrderHeader_Tabletki] oht
                LEFT JOIN [InternetSaleApteka].[dbo].[OrderDelivery_Tabletki] ort 
                ON oht.id = ort.ID
                WHERE oht.delivery = 1 AND oht.status_1c = 6 AND dateTimeCreated > DATEADD(D, -2,GETDATE())";

        var table = remoteSql.SelectQuery(query, new LogFile("Log"), "InternetSaleApteka");

        var orders = new List<OrderModel>();

        foreach (DataRow row in table.Rows)
        {
            var order = new OrderModel
            {
                Id = new Guid($"{row["id"]}"),
                Code = row["code"].ToString(),
                DateTimeCreated = Convert.ToDateTime(row["dateTimeCreated"]),
                CustomerPhone = row["customerPhone"].ToString(),
                CreateDateTime = Convert.ToDateTime(row["createDateTime"]),
                Status1c = Convert.ToInt32(row["status_1c"]),
                Approve = Convert.ToDateTime(row["Approve"]),
                Delivery = Convert.ToInt32(row["delivery"]),
                TTN1c = row["TTN_1C"].ToString(),
                TTN = row["TTN"].ToString(),
                DeliveryServiceName = row["DeliveryServiceName"].ToString(),
                DeliveryServiceAlias = row["DeliveryServiceAlias"].ToString(),
                FullName = row["FullName"].ToString(),
                CityReceiver = row["CityReceiver"].ToString(),
                IDWhs = new Guid($"{row["IDWhs"]}"),
                ReceiverWhs = row["ReceiverWhs"].ToString()
            };
            orders.Add(order);
        }

        return orders;
    }
}