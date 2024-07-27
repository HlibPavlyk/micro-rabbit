using System.Text;
using MicroRabbit.Mvc.Models.Dtos;
using Newtonsoft.Json;

namespace MicroRabbit.Mvc.Services;

public class TransferService : ITransferService
{
    private readonly HttpClient _client;
    private readonly string uri = "https://localhost:7087/api/Banking";

    public TransferService(HttpClient client)
    {
        _client = client;
    }

    public async Task Transfer(TransferDto transferDto)
    {
        var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto),
            Encoding.UTF8, "application/json");
        
        var response = await _client.PostAsync(uri, transferContent);
        response.EnsureSuccessStatusCode();
    }
}