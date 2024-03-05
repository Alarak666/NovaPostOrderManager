using Application.Services;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace NovaPostManagerr.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderPostService _orderService;
    public OrderController(IOrderPostService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
        var orders = _orderService.GetOrders();
        return Ok(orders);
    }
}