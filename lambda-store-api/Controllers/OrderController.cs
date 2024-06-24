using Microsoft.AspNetCore.Mvc;
using ShopLambda.API.Entities;
using ShopLambda.API.Services;

namespace ShopLambda.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(IOrderService service) : Controller
{
	[HttpPost]
	public async Task<IActionResult> Post([FromBody] Order order)
	{
		await service.CreateOrderAsync(order);
		return Created();
	}
}	