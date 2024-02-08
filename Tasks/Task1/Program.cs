class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");

        if (double.TryParse(Console.ReadLine(), out double depositAmount))
        {
            double interestRate;

            if (depositAmount < 100)
            {
                interestRate = 0.05;
            }
            else if (depositAmount <= 200)
            {
                interestRate = 0.07;
            }
            else
            {
                interestRate = 0.10;
            }

            double totalAmount = depositAmount * (1 + interestRate);

            Console.WriteLine($"Сумма вклада с начисленными процентами: {totalAmount}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число для суммы вклада.");
        }
    }
}