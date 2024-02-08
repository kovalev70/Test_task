using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task10.Frontend.Service.IService;
using Task10.Frontend.Models;
namespace Task10.Frontend.Pages.Models;

[IgnoreAntiforgeryToken]
public class CalculationModel : PageModel
{
    private readonly IDepositService _depositService;

    public string? Message { get; set; }

    public CalculationModel(IDepositService depositService)
    {
        _depositService = depositService;
    }

    public async Task OnPostAsync(decimal amount, int months)
    {
        Message = $"Итоговая сумма составит " +
            $"{await _depositService.GetFinalDeposit(amount, months)}";

        await _depositService.PostDepositInformation(
            new DepositCalculationInputModel(amount, months));
    }
}
