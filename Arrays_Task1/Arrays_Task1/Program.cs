// Работа с конкретными строками/столбцами
using System;

class Program
{
    static void Main()
    {
        int[,] array = { { 2, 3, 7 }, { 12, 3, 5 } };
        int sum = 0;
        int multiply = 1;

        Console.WriteLine("Existing array: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
                if (i == 1)
                {
                    sum += array[i, j];
                }
            }

            multiply *= array[i, 0];
            Console.WriteLine();
        }

        Console.Write("\nSum of the second line: ");
        Console.WriteLine(sum);

        Console.Write("Product of the first column: ");
        Console.WriteLine(multiply);
    }
}