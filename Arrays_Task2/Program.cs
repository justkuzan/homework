//Наибольший элемент

using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[10, 10];
        Random random = new Random();
        int comparisonNumber = Int32.MinValue;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i, 0] = random.Next(1, 6);
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 6);
            }
        }

        Console.WriteLine("Array has been generated:");
        foreach (int i in array)
            Console.Write($"{i} ");

        foreach (int i in array)
        {
            if (i > comparisonNumber)
            {
                comparisonNumber = i;
            }
        }

        Console.Write($"\n\nLargest number in array: {comparisonNumber} ");

        Console.WriteLine("\n\nA new matrix has been created:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == comparisonNumber)
                {
                    array[i, j] = 0;
                }

                Console.Write($"{array[i, j]} ");
            }
        }
    }
}