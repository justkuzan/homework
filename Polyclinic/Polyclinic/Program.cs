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
            
            const int RECEPTION_TIME_PER_PERSON = 10;
            
            Console.WriteLine("Вы заходите в поликлинику. Перед вами длинная очередь.");
            Console.WriteLine("Вы опаздываете, поэтому вам надо понять: сколько вы будете ждать в очереди");
            Console.WriteLine("Давайте начнем считать!");
            Console.WriteLine("Нажмите любую клавишу для старта....");
            Console.ReadKey();

            Console.WriteLine($"Время приема одного человека: {RECEPTION_TIME_PER_PERSON} минут");
            Console.WriteLine("Сколько перед вами людей?");
            int peopleInLine = int.Parse(Console.ReadLine());

            int minutesForWaiting = peopleInLine * RECEPTION_TIME_PER_PERSON;
            int hours = minutesForWaiting / 60;
            int minutes = minutesForWaiting % 60;
            
            Console.WriteLine($"Окей, перед вами {peopleInLine} человек. Это значит, что вам придется прождать:\n{hours} час. {minutes} мин.");
        }
    }
}