using System;
using System.Text;
using System.Threading.Channels;

/* Сумма чисел.

С помощью Random получить число number, которое не больше 100.
Найти сумму всех положительных чисел меньше number (включая число), которые кратные 3 или 5.
(К примеру, это числа 3, 5, 6, 9, 10, 12, 15 и т.д.) */

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int sumResult = 0;
            
            Random rand = new Random();
            int generatedNumber = rand.Next(0, 101);
            Console.WriteLine($"Сгенерированное число: {generatedNumber}");

            for (int i = 0; i <= generatedNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write($"Число кратное 3 или 5: {i} ");
                    Console.WriteLine();
                    sumResult += i;
                }
            }
            Console.Write($"Сумма чисел:{sumResult}");
        }
    }
}