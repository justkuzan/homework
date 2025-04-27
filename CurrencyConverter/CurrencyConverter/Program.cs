using System;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
           
            //Switch constants
            const string CommandUsdToEur = "1";
            const string CommandUsdToCny = "2";
            const string CommandEurToUsd = "3";
            const string CommandEurToCny = "4";
            const string CommandCnyToUsd = "5";
            const string CommandCnyToEur = "6";
            const string CommandExit = "exit";
            
            //Currencies
            float dollarsInWallet = 100f;
            float euroInWallet = 100f;
            float yuanInWallet = 100f;
            
            //Exchange Rates
            float euroToDollar = 1.14f;
            float dollarToEuro = 0.88f;
            float yuanToDollar = 0.14f;
            float dollarToYuan = 7.2f;
            float euroToYuan = 8.28f;
            float yuanToEuro = 0.12f;
            
            bool isRunning = true;

            int usersIncomingAmount;
            float convertedAmount;
            string userChoiseForContinue;

            while (isRunning)
            {
                Console.WriteLine($"У вас в кошельке:\n" +
                                  $"{dollarsInWallet} долларов\n" +
                                  $"{euroInWallet} евро\n" + 
                                  $"{yuanInWallet} юаней\n");
                Console.WriteLine("Выберите тип операции:");
                Console.WriteLine("1. Поменять Доллары на Евро\n" +
                                  "2. Поменять Доллары на Юани\n" +
                                  "-----\n" +
                                  "3. Поменять Евро на Доллары\n" +
                                  "4. Поменять Евро на Юани\n" +
                                  "-----\n" +
                                  "5. Поменять Юани на Доллары\n" +
                                  "6. Поменять Юани на Евро\n" +
                                  "-----\n" +
                                  "Для выхода введите exit");
                
                string userChoise = Console.ReadLine();

                switch (userChoise.ToLower())
                {
                    case CommandUsdToEur:
                        //UI
                        Console.WriteLine($"У вас {dollarsInWallet} долларов в кошельке." +
                                          $"Текущий курс: {dollarToEuro} евро за 1 доллар\n" +
                                          $"Сколько долларов вы хотите поменять на евро?\n");
                        usersIncomingAmount = int.Parse(Console.ReadLine());
                        
                        //Calculations
                        convertedAmount = usersIncomingAmount * dollarToEuro;
                        dollarsInWallet -= usersIncomingAmount;
                        euroInWallet += convertedAmount;
                        
                        //UI
                        Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} долларов на {convertedAmount} евро\n");
                        Console.WriteLine($"У вас в кошельке:\n" +
                                          $"{dollarsInWallet} долларов\n" +
                                          $"{euroInWallet} евро\n" + 
                                          $"{yuanInWallet} юаней\n" +
                                          $"-----\n");
                        
                        //Repeat
                        Console.WriteLine("Для проведения еще одной операции нажмите Enter\n" +
                                          "Для выхода введите exit");
                        
                        userChoiseForContinue = Console.ReadLine();
                        if (userChoiseForContinue.ToLower() == "exit")
                        {
                            isRunning = false;
                            Console.WriteLine("Выход из приложения...");
                        }
                        break;
                    
                    case CommandUsdToCny:
                        //UI
                        Console.WriteLine($"У вас {dollarsInWallet} долларов в кошельке." +
                                          $"Текущий курс: {dollarToYuan} юаней за 1 доллар\n" +
                                          $"Сколько долларов вы хотите поменять на юани?\n");
                        usersIncomingAmount = int.Parse(Console.ReadLine());
                        
                        //Calculations
                        convertedAmount = usersIncomingAmount * dollarToYuan;
                        dollarsInWallet -= usersIncomingAmount;
                        yuanInWallet += convertedAmount;
                        
                        //UI
                        Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} долларов на {convertedAmount} юаней\n");
                        Console.WriteLine($"У вас в кошельке:\n" +
                                          $"{dollarsInWallet} долларов\n" +
                                          $"{euroInWallet} евро\n" + 
                                          $"{yuanInWallet} юаней\n" +
                                          $"-----\n");
                        
                        //Repeat
                        Console.WriteLine("Для проведения еще одной операции нажмите Enter\n" +
                                          "Для выхода введите exit");
                        
                        userChoiseForContinue = Console.ReadLine();
                        if (userChoiseForContinue.ToLower() == "exit")
                        {
                            isRunning = false;
                            Console.WriteLine("Выход из приложения...");
                        }
                        break;
                        
                    case CommandEurToUsd:
                        //UI
                        Console.WriteLine($"У вас {euroInWallet} евро в кошельке." +
                                          $"Текущий курс: {euroToDollar} евро за 1 доллар\n" +
                                          $"Сколько евро вы хотите поменять на доллары?\n");
                        usersIncomingAmount = int.Parse(Console.ReadLine());
                        
                        //Calculations
                        convertedAmount = usersIncomingAmount * euroToDollar;
                        euroInWallet -= usersIncomingAmount;
                        dollarsInWallet += convertedAmount;
                        
                        //UI
                        Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} евро на {convertedAmount} долларов\n");
                        Console.WriteLine($"У вас в кошельке:\n" +
                                          $"{dollarsInWallet} долларов\n" +
                                          $"{euroInWallet} евро\n" + 
                                          $"{yuanInWallet} юаней\n" +
                                          $"-----\n");
                        
                        //Repeat
                        Console.WriteLine("Для проведения еще одной операции нажмите Enter\n" +
                                          "Для выхода введите exit");
                        
                        userChoiseForContinue = Console.ReadLine();
                        if (userChoiseForContinue.ToLower() == "exit")
                        {
                            isRunning = false;
                            Console.WriteLine("Выход из приложения...");
                        }
                        break;
                    
                    case CommandEurToCny:
                        //UI
                        Console.WriteLine($"У вас {euroInWallet} евро в кошельке." +
                                          $"Текущий курс: {euroToYuan} евро за 1 юань\n" +
                                          $"Сколько евро вы хотите поменять на юани?\n");
                        usersIncomingAmount = int.Parse(Console.ReadLine());
                        
                        //Calculations
                        convertedAmount = usersIncomingAmount * euroToYuan;
                        euroInWallet -= usersIncomingAmount;
                        yuanInWallet += convertedAmount;
                        
                        //UI
                        Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} евро на {convertedAmount} юаней\n");
                        Console.WriteLine($"У вас в кошельке:\n" +
                                          $"{dollarsInWallet} долларов\n" +
                                          $"{euroInWallet} евро\n" + 
                                          $"{yuanInWallet} юаней\n" +
                                          $"-----\n");
                        
                        //Repeat
                        Console.WriteLine("Для проведения еще одной операции нажмите Enter\n" +
                                          "Для выхода введите exit");
                        
                        userChoiseForContinue = Console.ReadLine();
                        if (userChoiseForContinue.ToLower() == "exit")
                        {
                            isRunning = false;
                            Console.WriteLine("Выход из приложения...");
                        }
                        break;
                    
                    case CommandCnyToUsd:
                        //UI
                        Console.WriteLine($"У вас {yuanInWallet} юаней в кошельке." +
                                          $"Текущий курс: {yuanToDollar} юаней за 1 доллар\n" +
                                          $"Сколько юаней вы хотите поменять на доллары?\n");
                        usersIncomingAmount = int.Parse(Console.ReadLine());
                        
                        //Calculations
                        convertedAmount = usersIncomingAmount * yuanToDollar;
                        yuanInWallet -= usersIncomingAmount;
                        dollarsInWallet += convertedAmount;
                        
                        //UI
                        Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} юаней на {convertedAmount} долларов\n");
                        Console.WriteLine($"У вас в кошельке:\n" +
                                          $"{dollarsInWallet} долларов\n" +
                                          $"{euroInWallet} евро\n" + 
                                          $"{yuanInWallet} юаней\n" +
                                          $"-----\n");
                        
                        //Repeat
                        Console.WriteLine("Для проведения еще одной операции нажмите Enter\n" +
                                          "Для выхода введите exit");
                        
                        userChoiseForContinue = Console.ReadLine();
                        if (userChoiseForContinue.ToLower() == "exit")
                        {
                            isRunning = false;
                            Console.WriteLine("Выход из приложения...");
                        }
                        break;
                    
                    case CommandCnyToEur:
                        //UI
                        Console.WriteLine($"У вас {yuanInWallet} юаней в кошельке." +
                                          $"Текущий курс: {yuanToEuro} юаней за 1 евро\n" +
                                          $"Сколько юаней вы хотите поменять на евро?\n");
                        usersIncomingAmount = int.Parse(Console.ReadLine());
                        
                        //Calculations
                        convertedAmount = usersIncomingAmount * yuanToEuro;
                        yuanInWallet -= usersIncomingAmount;
                        euroInWallet += convertedAmount;
                        
                        //UI
                        Console.WriteLine($"Вы успешно поменяли {usersIncomingAmount} юаней на {convertedAmount} евро\n");
                        Console.WriteLine($"У вас в кошельке:\n" +
                                          $"{dollarsInWallet} долларов\n" +
                                          $"{euroInWallet} евро\n" + 
                                          $"{yuanInWallet} юаней\n" +
                                          $"-----\n");
                        
                        //Repeat
                        Console.WriteLine("Для проведения еще одной операции нажмите Enter\n" +
                                          "Для выхода введите exit");
                        
                        userChoiseForContinue = Console.ReadLine();
                        if (userChoiseForContinue.ToLower() == "exit")
                        {
                            isRunning = false;
                            Console.WriteLine("Выход из приложения...");
                        }
                        break;
                    
                    case CommandExit:
                        isRunning = false;
                        Console.WriteLine("Выход из приложения...");
                        break;
                    
                    default:
                    Console.WriteLine("Неизвестная операция");
                    break;
                }
            }
        }
    }
}