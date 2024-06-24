using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SubRequestsLambda;

public class Function
{
	public async Task FunctionHandler(SQSEvent input, ILambdaContext context)
	{
		foreach (var message in input.Records)
		{
			await ProcessMessageAsync(message, context);
		}

		await Task.CompletedTask;
	}

	private async Task ProcessMessageAsync(SQSEvent.SQSMessage message, ILambdaContext context)
	{
		context.Logger.LogLine($"Processed message {message.Body}");
		await Task.Delay(1000);
		context.Logger.LogLine($"Finished processing message {message.Body}");
		await Task.CompletedTask;
	}
}