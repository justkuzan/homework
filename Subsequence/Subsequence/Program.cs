using System;
using System.Text;
using System.Threading.Channels;

/*Последовательность.
 
Нужно написать программу (используя циклы, обязательно пояснить выбор вашего цикла), чтобы она выводила следующую последовательность:
5 12 19 26 33 40 47 54 61 68 75 82 89 96
Нужны переменные для обозначения чисел в условии цикла. */

/* Сразу поясняю. Будем делать на цикле for, так как известна длинна последовательности, ее составные элементы и алгоритм цикла */

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            int stepOfProgression = 7;
            int minValue = 5;
            int maxValue = 96;

            for (int i = minValue; i <= maxValue; i += stepOfProgression)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Выведены все необходимые числа от {minValue} до {maxValue} с шагом в {stepOfProgression}");
        }
    }
}