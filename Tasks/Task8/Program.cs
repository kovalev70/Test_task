class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string? input = Console.ReadLine();

        int totalPlusMinus = 0;
        int zerosAfterChar = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '+' || input[i] == '-')
            {
                totalPlusMinus++;
            }

            if (i + 1 < input.Length && input[i + 1] == '0')
            {
                zerosAfterChar++;
            }
        }

        Console.WriteLine($"Общее количество символов '+' и '-': {totalPlusMinus}");
        Console.WriteLine($"Количество символов, после которых следует цифра ноль: {zerosAfterChar}");
    }
}