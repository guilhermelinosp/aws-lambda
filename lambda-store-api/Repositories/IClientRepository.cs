using ShopLambda.API.Entities;

namespace ShopLambda.API.Repositories;

public interface IClientRepository
{
	Task CreateAsync(Client client);
	Task UpdateAsync(Client client);
	Task DeleteAsync(string document);
	Task<Client?> FindAllAsync (string document); 
}