class Program
{
    static void Main()
    {
        int[,,] array = { { { 1, 2 }, { 3, 4 } },
                        { { 4, 5 }, { 6, 7 } },
                        { { 7, 8 }, { 9, 10 } },
                        { { 10, 11 }, { 12, 13 } }
                      };

        int firstDimensionLength = array.GetLength(0);
        int secondDimensionLength = array.GetLength(1);
        int thirdDimensionLength = array.GetLength(2);

        Console.Write("{");
        for (int i = 0; i < firstDimensionLength; i++)
        {
            Console.Write("{");
            for (int j = 0; j < secondDimensionLength; j++)
            {
                Console.Write("{");
                for (int k = 0; k < thirdDimensionLength; k++)
                {
                    Console.Write(array[i, j, k]);
                    if (k < thirdDimensionLength - 1)
                        Console.Write(" , ");
                }
                Console.Write("}");
                if (j < secondDimensionLength - 1)
                    Console.Write(" , ");
            }
            Console.Write("}");
            if (i < firstDimensionLength - 1)
                Console.Write(" , ");
        }
        Console.Write("}");
    }
}