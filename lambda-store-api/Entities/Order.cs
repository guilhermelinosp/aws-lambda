using ShopLambda.API.Enums;

namespace ShopLambda.API.Entities;

public class Order
{
	public Guid OrderId { get; } = Guid.NewGuid(); 
	
	public OrderStatus Status { get; set; } = OrderStatus.AGUARDANDO_PAGAMENTO;
	public string? DocumentClient  => Client!.Documento; 
	public Client? Client { get; set; }
	public decimal Total => Items.Sum(i => i.Price * i.Quantity);
	public DateTime CreatedAt { get; } = DateTime.Now;
	public List<OrderItem> Items { get; set; } = [];
}