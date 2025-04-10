using System;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            Console.Write("Как вас зовут? ");
            string userName = Console.ReadLine();
            
            Console.Write("Сколько вам лет? ");
            int userAge = int.Parse(Console.ReadLine());
            
            Console.Write("Какой у вас знак зодиака? ");
            string userZodiac = Console.ReadLine();
            
            Console.Write("Кем вы работаете? ");
            string userJob = Console.ReadLine();

            Console.WriteLine($"Ваше имя {userName}, вам {userAge} лет, вы {userZodiac} по знаку зодиака и вы работаете {userJob}");
        }
    }
}