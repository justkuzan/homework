using System;
using System.Text;
using System.Threading.Channels;

/*Освоение циклов.
 
Напишите простейшую программу, которая выводит указанное(установленное) пользователем сообщение заданное количество раз.
Количество повторов также должен ввести пользователь.
*/

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string userMessage;
            int numberOfMessageOutputs;

            Console.WriteLine("Какое сообщение вы хотите вывести?");
            userMessage = Console.ReadLine();
            Console.WriteLine("Сколько раз вы хотите вывести это сообщение?");
            numberOfMessageOutputs = int.Parse(Console.ReadLine());

            if (numberOfMessageOutputs > 0)
            {
                for (int i = 0; i < numberOfMessageOutputs; i++)
                {
                    Console.WriteLine(userMessage);
                }
                Console.WriteLine($"Вы вывели \"{userMessage}\" {numberOfMessageOutputs} раз");
            }
            else if (numberOfMessageOutputs == 0)
            {
                Console.WriteLine($"Вы захотели вывести сообщение {numberOfMessageOutputs} раз.\nСоответственно, мы его не выводим.");
            }
            else
            {
                Console.WriteLine("Нельзя вызвать сообщение отрицательное количество раз");
            }
        }
    }
}