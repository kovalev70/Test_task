namespace Task10.Backend.Models.Domain;

public class Deposit
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public int Months { get; set; }
}
