// Работа с конкретными строками/столбцами

internal class Program
{
    private static void Main()
    {
        int[,] array = { { 2, 3, 7 }, { 12, 3, 5 } };
        var sum = 0;
        var multiply = 1;

        Console.WriteLine("Existing array: ");
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
                if (i == 1) sum += array[i, j];
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