using Task10.Frontend.Models;

namespace Task10.Frontend.Service.IService;

public interface IDepositService
{
    Task<decimal> GetFinalDeposit (decimal deposit, int months);

    Task PostDepositInformation(DepositCalculationInputModel depositModel);
}
