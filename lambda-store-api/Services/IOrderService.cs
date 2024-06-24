using ShopLambda.API.Entities;

namespace ShopLambda.API.Services;

public interface IOrderService
{
	Task CreateOrderAsync(Order order);
}