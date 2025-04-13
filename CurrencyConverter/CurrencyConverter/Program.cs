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
            
            //Currencies
            float dollarsInWallet = 100f;
            float euroInWallet = 0f;
            float yuanInWallet = 0f;
            float dollarsLeft;
            
            //Exchange Rates
            float euroExchangeRate = 0.9f;
            float yuanExchangeRate = 7.2f;
            
            //Users Actions
            int usersIncomingAmount;
            string userChoise;
                
            Console.WriteLine($"У вас {dollarsInWallet} долларов в кошельке");
            Console.WriteLine("Выберите требуемую операцию:");
            Console.WriteLine("1. Поменять USD на EUR");
            Console.WriteLine("2. Поменять USD на CNY");
            
            userChoise = Console.ReadLine();
            
            switch (userChoise)
            {
                case "1":
                    Console.WriteLine($"У вас {dollarsInWallet} долларов в кошельке. Сколько долларов вы хотите поменять на EUR?");
                    usersIncomingAmount = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Вы хотите поменять {usersIncomingAmount} долларов на EUR. Текущий курс: {euroExchangeRate} евро за 1 доллар. Хотите продолжить?");
                    Console.WriteLine("Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    
                    euroInWallet = usersIncomingAmount * euroExchangeRate;
                    dollarsLeft = dollarsInWallet - usersIncomingAmount;

                    Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} долларов на {euroInWallet} евро");
                    Console.WriteLine($"Сейчас у вас в кошельке {dollarsLeft} долларов и {euroInWallet} евро");
                    break;
                
                case "2":
                    Console.WriteLine($"У вас {dollarsInWallet} долларов в кошельке. Сколько долларов вы хотите поменять на CNY?");
                    usersIncomingAmount = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Вы хотите поменять {usersIncomingAmount} долларов на CNY. Текущий курс: {yuanExchangeRate} юаней за 1 доллар. Хотите продолжить?");
                    Console.WriteLine("Для продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    
                    yuanInWallet = usersIncomingAmount * yuanExchangeRate;
                    dollarsLeft = dollarsInWallet - usersIncomingAmount;

                    Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} долларов на {yuanInWallet} юаней");
                    Console.WriteLine($"Сейчас у вас в кошельке {dollarsLeft} долларов и {yuanInWallet} юаней");
                    break;
                
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}