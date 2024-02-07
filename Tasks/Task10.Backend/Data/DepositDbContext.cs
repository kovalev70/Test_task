using Microsoft.EntityFrameworkCore;
using Task10.Backend.Models.Domain;

namespace Task10.Backend.Data;

public class DepositDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DepositDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Deposit> Deposits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Npgsql"));
    }
}
