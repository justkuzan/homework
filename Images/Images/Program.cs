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

            int imagesInRow = 3;
            
            Console.WriteLine("Сейчас мы будем выводить вам картинки по 3 в ряд.\nСколько у вас всего картинок?");
            int numberOfImages = int.Parse(Console.ReadLine());
            
            int totalRows = numberOfImages / imagesInRow;

            Console.WriteLine($"{numberOfImages} картинок полностью заполнят {totalRows} строк (по {imagesInRow} картинки в ряд) ");
        }
    }
}