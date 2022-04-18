using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Steam.Aplication;
using ConsoleApp1.Models;
using System.IO;
using Steam.Aplication.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SteamClient.ds.Load(out AccountProvider.accounts, out GameShop.AllGames);

            while (true)
            {
              
                Console.Clear();

                Console.WriteLine("1.Register\n" +
                                  "2.Sign in\n" +
                                  "3.Exit from Steam");

                switch (Console.ReadLine())
                {
                    case "1":

                        Console.Clear();
                        Console.WriteLine("write login:");
                        string login = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("write nickname:");
                        string nickName = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("write password:");
                        string password = Console.ReadLine();

                        Console.Clear();
                        string registerInfo = AccountProvider.Register(login, nickName, password);

                        Console.WriteLine(registerInfo);
                        Console.ReadKey();

                        break;

                    case "2":

                        Console.Clear();
                        Console.WriteLine("write login:");
                        string caseLogin = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("write password:");
                        string casePassword = Console.ReadLine();

                        if (AccountProvider.CheckAccount(caseLogin, casePassword))
                        {
                            AccountProvider.SignIn(caseLogin, casePassword);
                            Console.Clear();
                            Console.WriteLine("Success");
                            Console.ReadKey();
                            Models.MenuManager.StartMainMenu();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Somewhere mistake. Please, try againe");
                            Console.ReadKey();
                            break;
                        }

                    case "3":

                        for (int i = 0; i < 3; i++)
                        {
                            Console.Clear();
                            Console.Write("closing");
                            Thread.Sleep(200);
                            Console.Write(".");
                            Thread.Sleep(200);
                            Console.Write(".");
                            Thread.Sleep(200);
                            Console.Write(".");
                        }
                        SteamClient.ds.Save(AccountProvider.accounts, Steam.Aplication.Models.GameShop.AllGames);
                        Process.GetCurrentProcess().Kill();
                        break;

                }
            }
        }
    }
}
