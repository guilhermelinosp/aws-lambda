using Amazon.DynamoDBv2.DataModel;

namespace ShopLambda.API.Entities;

[DynamoDBTable("Client")]
public class Client
{
	[DynamoDBHashKey("Document")]
	public string? Documento { get; set; }
	public string? Nome { get; set; }
	public string? Email { get; set; }
	public Address? Endereco { get; set; }
}