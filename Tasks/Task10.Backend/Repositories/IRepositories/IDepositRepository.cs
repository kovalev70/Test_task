using Task10.Backend.Models.Domain;

namespace Task10.Backend.Repositories.IRepositories;

public interface IDepositRepository
{
    Task<Deposit> CreateAsync(Deposit deposit);
}
