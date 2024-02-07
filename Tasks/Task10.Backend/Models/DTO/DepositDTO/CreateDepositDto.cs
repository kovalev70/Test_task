namespace Task10.Backend.Models.DTO.DepositDTO;

public class CreateDepositDto
{
    public decimal Amount { get; set; }
    public int Months { get; set; }

    public CreateDepositDto(decimal amount, int months) 
    {
        Amount = amount;
        Months = months;
    }
}
