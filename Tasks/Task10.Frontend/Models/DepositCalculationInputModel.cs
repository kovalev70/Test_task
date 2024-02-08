namespace Task10.Frontend.Models;

public class DepositCalculationInputModel
{
    public decimal Amount {  get; set; }
    public int Months { get; set; }

    public DepositCalculationInputModel(decimal amount, int months) 
    {
        Amount = amount;
        Months = months;
    }
}
