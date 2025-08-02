//Локальные максимумы

internal class Program
{
    private static void Main()
    {
        var array = new int[30];
        var rnd = new Random();

        Console.WriteLine("Generated array: ");
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100);
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("\n\nLocal maxima: ");
        for (var i = 0; i < array.Length; i++)
            if (i == 0 && array[0] > array[1])
                Console.Write($"{array[i]} ");

            else if (i == array.Length - 1 && array[array.Length - 1] > array[array.Length - 2])
                Console.Write($"{array[i]} ");

            else if (i <= array.Length - 2 && i >= 1 && array[i] > array[i - 1] && array[i] > array[i + 1])
                Console.Write($"{array[i]} ");
    }
}