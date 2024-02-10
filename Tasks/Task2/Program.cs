
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,,] array = { { { 1, 2 }, { 3, 4 } },
                          { { 4, 5 }, { 6, 7 } },
                          { { 7, 8 }, { 9, 10 } },
                          { { 10, 11 }, { 12, 13 } }
                        };

        Console.Write("{");
        Console.Write(string.Join(" , ", Enumerable.Range(0, array.GetLength(0))
            .Select(i => "{" + string.Join(" , ", Enumerable.Range(0, array.GetLength(1))
                .Select(j => "{" + string.Join(" , ", Enumerable.Range(0, array.GetLength(2))
                    .Select(k => array[i, j, k])) + "}")) + "}")));
        Console.Write("}");
    }
}