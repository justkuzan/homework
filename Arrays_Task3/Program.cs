//Локальные максимумы

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Random rnd = new Random();

        Console.WriteLine("Generated array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 100);
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("\n\nLocal maxima: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i + 1])
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}