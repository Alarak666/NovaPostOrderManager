namespace Core.Dto;

public class OrderModel
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public DateTime DateTimeCreated { get; set; }
    public string CustomerPhone { get; set; }
    public DateTime CreateDateTime { get; set; }
    public int Status1c { get; set; }
    public DateTime Approve { get; set; }
    public int Delivery { get; set; }
    public string? TTN1c { get; set; }
    public string? TTN { get; set; }
    public string DeliveryServiceName { get; set; }
    public string DeliveryServiceAlias { get; set; }
    public string FullName { get; set; }
    public string CityReceiver { get; set; }
    public Guid IDWhs { get; set; }
    public string ReceiverWhs { get; set; }
}