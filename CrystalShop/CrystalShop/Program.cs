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

            //Player Settings
            int totalPlayersMoney = 100;
            
            //Product Settings
            string crystalType = "Королевский сапфир";
            int crystalPrice = 12;
            
            Console.WriteLine($"У вас {totalPlayersMoney} монет");
            Console.WriteLine();
            Console.WriteLine("Добро пожаловать в \"Аметистовый Оберег\"! ");
            Console.WriteLine($"Сегодня у нас акция на {crystalType}! Всего по {crystalPrice} монет за штуку!");
            Console.WriteLine();
            Console.WriteLine("Сколько штук вы хотите купить?");
            
            int userNumberOfCrystals = int.Parse(Console.ReadLine());
            int totalMoneySpent = userNumberOfCrystals * crystalPrice;
            int totalMoneyLeft = totalPlayersMoney - totalMoneySpent;
            
            Console.WriteLine($"Вы купили {userNumberOfCrystals} кристаллов \"{crystalType}\"!");
            Console.WriteLine($"Это обошлось вам в {totalMoneySpent} монет.");
            Console.WriteLine($"У вас осталось {totalMoneyLeft} монеты");
        }
    }
}