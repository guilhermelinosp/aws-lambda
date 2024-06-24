namespace ShopLambda.API.Entities;

public class OrderItem
{
	public Guid OrderItemId { get; } = Guid.NewGuid();
	public Guid ProductId { get; set; }
	public int Quantity { get; set; }
	public decimal Price { get; set; }
}