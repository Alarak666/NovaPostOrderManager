using Core.Dto;
using System.Data;

namespace Core.Interface;

public interface IOrderPostService
{
    Task<DataTable> GetOrders();
}