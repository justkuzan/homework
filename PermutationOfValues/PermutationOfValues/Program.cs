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
            
            string firstName = "Пупкин";
            string lastName = "Василий";

            Console.WriteLine($"Имя: {firstName}, Фамилия: {lastName}");
            Console.WriteLine("Нажмите любую клавишу, чтобы поменять Имя и Фамилию местами...");
            Console.ReadKey();

            (firstName, lastName) = (lastName, firstName);
                
            Console.WriteLine($"Имя и Фамилия поменялись местами.\nТеперь Имя: {firstName}, Фамилия: {lastName}");
        }
    }
}