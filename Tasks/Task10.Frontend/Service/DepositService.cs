using System.Text.Json;
using System.Text;
using Task10.Frontend.Service.IService;
using Task10.Frontend.Models;
using System.Globalization;

namespace Task10.Frontend.Service;

public class DepositService : IDepositService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly string _baseUrl;

    public DepositService(IHttpClientFactory clientFactory, IConfiguration configuration)
    {
        _httpClientFactory = clientFactory;
        _baseUrl = configuration.GetConnectionString("DepositApi");
    }
    public async Task PostDepositInformation(DepositCalculationInputModel depositModel)
    {
        HttpClient client = _httpClientFactory.CreateClient("DepositApi");
        var json = JsonSerializer.Serialize(depositModel);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var url = _baseUrl + $"/api/deposit";
        var response = await client.PostAsync(url, content);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Не удалось получить итоговую сумму депозита.");
        }
    }

    public async Task<decimal> GetFinalDeposit(decimal amount, int months)
    {
        HttpClient client = _httpClientFactory.CreateClient("DepositApi");
        var url = _baseUrl + $"/api/deposit?amount={amount}&months={months}";
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var result = decimal.Parse(await response.Content.ReadAsStringAsync(), CultureInfo.InvariantCulture);
            return result;
        }

        throw new Exception("Не удалось получить итоговую сумму депозита.");
    }
}
