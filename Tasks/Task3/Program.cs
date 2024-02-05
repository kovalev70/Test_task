class Program
{
    static void Main()
    {
        int[] array = { 6, 7, 2, 3, 9, 4, 7, 1, 3, 6, 8, 3, 7, 8, 3 };
        int minSum = int.MaxValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int currentSum = array[i] + array[i + 1];

            if (currentSum < minSum)
            {
                minSum = currentSum;
            }
        }

        Console.WriteLine($"Минимальная сумма: {minSum}");
    }
}