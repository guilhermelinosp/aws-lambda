using Amazon.DynamoDBv2.DataModel;
using ShopLambda.API.Entities;

namespace ShopLambda.API.Repositories;

public class ClientRepository(IDynamoDBContext context) : IClientRepository
{
	public async Task CreateAsync(Client client)
	{
		await context.SaveAsync<Client>(client);
	}

	public async Task UpdateAsync(Client client)
	{
		await context.SaveAsync<Client>(client);
	}

	public async Task DeleteAsync(string document)
	{
		await context.DeleteAsync<Client>(document);
	}

	public async Task<Client?> FindAllAsync(string document)
	{
		return await context.LoadAsync<Client?>(document);
	}
}