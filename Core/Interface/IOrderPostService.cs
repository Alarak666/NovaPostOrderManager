using Core.Dto;

namespace Core.Interface;

public interface IOrderPostService
{
    Task<ICollection<OrderModel>> GetOrders();
}