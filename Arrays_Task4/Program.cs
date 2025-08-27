// Динамический массив

namespace Arrays_Task4;

public class Program
{
    private static void Main()
    {
        var array = new int[0];
        Greetings();
        
        while (true)
        {
            var userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
                break;

            //TryParse еще не проходил, посмотрел у SimpleCode как работает и в чем смысл
            int userNumber;
            var isNumber = int.TryParse(userInput, out userNumber);
            if (isNumber)
            {
                var newArray = new int[array.Length + 1];

                for (var i = 0; i < array.Length; i++)
                    newArray[i] = array[i];

                newArray[newArray.Length - 1] = userNumber;
                array = newArray;
            }

            else if (userInput == "sum")
            {
                Console.WriteLine("Sum of numbers in array: " + array.Sum());
            }

            else
            {
                TypingError();
            }
        }

        static void Greetings()
        {
            Console.WriteLine("Good day!");
            Console.WriteLine("\nEnter number" +
                              "\nOr \"sum\" for sum" +
                              "\nOr \"exit\" for exit\n");
            Console.WriteLine("Enter numbers into the array:");
        }

        static void TypingError()
        {
            Console.WriteLine("\nUnknown symbol." +
                              "\nEnter number" +
                              "\nOr \"sum\" for sum" +
                              "\nOr \"exit\" for exit\n");
        }
    }
}