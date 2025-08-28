// Подмассив повторений чисел

namespace Arrays_Task5;

public class Program
{
    public static void Main()
    {
        var array = new int[30];
        var random = new Random();

        var numberOfRepetitions = 1;
        var maxRepetitions = 1;
        var repeatingNumber = array[0];

        Console.WriteLine("Array: ");
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1,5);
            Console.Write(array[i] + " ");
        }

        for (var i = 1; i < array.Length; i++)
            if (array[i] == array[i - 1])
            {
                numberOfRepetitions++;
                if (numberOfRepetitions > maxRepetitions)
                {
                    maxRepetitions = numberOfRepetitions;
                    repeatingNumber = array[i];
                }
            }
            else
            {
                numberOfRepetitions = 1;
            }

        Console.WriteLine();
        Console.WriteLine($"Число {repeatingNumber} повторяется {maxRepetitions} раз подряд");
    }
}