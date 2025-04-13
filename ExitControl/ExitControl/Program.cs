using System;
using System.Text;
using System.Threading.Channels;

/*Контроль выхода.
 
Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
*/

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            string codeWord = "exit";
            string userInput = "";
            
            Console.WriteLine("Добро пожаловать в квест-комнату!");
            Console.WriteLine("Чтобы выйти из комнаты, вам нужно ввести правильный пароль.");
            Console.WriteLine("Пароль: слово \"tixe\" наоборот");
            
            while (userInput != codeWord)
            {
                Console.WriteLine("Введите пароль:");
                userInput = Console.ReadLine();
                if (userInput != codeWord)
                {
                    Console.WriteLine("Вы ввели неверный пароль");
                }
            }
            
            Console.WriteLine("Вы ввели верный пароль! Теперь вы можете покинуть комнату!");
        }
    }
}