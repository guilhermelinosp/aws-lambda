using Microsoft.AspNetCore.Mvc;
using ShopLambda.API.Entities;
using ShopLambda.API.Repositories;

namespace ShopLambda.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController(IClientRepository repository) : Controller
{
	// GET: api/Client/{id}
	[HttpGet("{document}")]
	public async Task<IActionResult> Get(string document)
	{
		var client = await repository.FindAllAsync(document);
		if (client == null)
		{
			return NotFound();
		}

		return Ok(client);
	}

	// POST: api/Client
	[HttpPost]
	public async Task<IActionResult> Post([FromBody] Client client)
	{
		await repository.CreateAsync(client);
		return Created();
	}

	// PUT: api/Client/{id}
	[HttpPut("{document}")]
	public async Task<IActionResult> Put(string document, [FromBody] Client client)
	{
		await repository.UpdateAsync(client);
		return NoContent();
	}

	// DELETE: api/Client/{id}
	[HttpDelete("{document}")]
	public async Task<IActionResult> Delete(string document)
	{
		await repository.DeleteAsync(document);
		return NoContent();
	}
}