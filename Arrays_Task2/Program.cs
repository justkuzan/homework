//Наибольший элемент

internal class Program
{
    private static void Main()
    {
        var array = new int[10, 10];
        var random = new Random();
        var comparisonNumber = int.MinValue;

        for (var i = 0; i < array.GetLength(0); i++)
        {
            array[i, 0] = random.Next(1, 6);
            for (var j = 0; j < array.GetLength(1); j++) array[i, j] = random.Next(1, 6);
        }

        Console.WriteLine("Array has been generated:");
        foreach (var i in array)
            Console.Write($"{i} ");

        foreach (var i in array)
            if (i > comparisonNumber)
                comparisonNumber = i;

        Console.Write($"\n\nLargest number in array: {comparisonNumber} ");

        Console.WriteLine("\n\nA new matrix has been created:");
        for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == comparisonNumber) array[i, j] = 0;

            Console.Write($"{array[i, j]} ");
        }
    }
}