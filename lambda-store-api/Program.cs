using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.SQS;
using ShopLambda.API.Repositories;
using ShopLambda.API.Services;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddControllers();
services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

services.AddScoped<IAmazonDynamoDB, AmazonDynamoDBClient>();
services.AddScoped<IAmazonSQS, AmazonSQSClient>();
services.AddScoped<IDynamoDBContext, DynamoDBContext>();
services.AddScoped<IClientRepository, ClientRepository>();
services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Welcome to running ASP.NET Core Minimal API on AWS Lambda");

app.Run();