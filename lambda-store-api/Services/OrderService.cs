using System.Text.Json;
using Amazon.SQS;
using Amazon.SQS.Model;
using ShopLambda.API.Entities;

namespace ShopLambda.API.Services;

public class OrderService(IAmazonSQS sqs) : IOrderService
{
	public async Task CreateOrderAsync(Order order)
	{
		await sqs.SendMessageAsync(new SendMessageRequest
		{
			QueueUrl = "https://sqs.sa-east-1.amazonaws.com/232568780654/requests-created-sqs",
			MessageBody = JsonSerializer.Serialize(order)
		});
	}
}