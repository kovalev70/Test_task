using Task10.Backend.Data;
using Task10.Backend.Models.Domain;
using Task10.Backend.Repositories.IRepositories;

namespace Task10.Backend.Repositories;

public class PostgresDepositRepository : IDepositRepository
{
    private readonly DepositDbContext _dbContext;

    public PostgresDepositRepository(DepositDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Deposit> CreateAsync(Deposit deposit)
    {
        await _dbContext.Deposits.AddAsync(deposit);
        await _dbContext.SaveChangesAsync();
        return deposit;
    }
}
