using Steam.Aplication;
using Steam.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp1.Models
{
    static class MenuManager
    {
        public static void StartMainMenu()
        {
           
            if (SteamClient.CurrentAccount != null)
            {

                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("1.Wallet\n" +
                                      "2.Account information\n" +
                                      "3.Edit account\n" +
                                      "4.Game library\n" +
                                      "5.Market\n" +
                                      "6.Exit from account\n" +
                                      "7.Exit from Steam");

                    switch (Console.ReadLine())
                    {


                        case "1":
                            Console.Clear();
                            Console.WriteLine(AccountProvider.WalletInfo());
                            Wallet();
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine(AccountProvider.AccountInfo());
                            Console.ReadKey();
                            break;

                        case "3":
                            Console.Clear();
                            RegisterMM();
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine(SteamClient.ShowGameLibrary());
                            Console.ReadKey();
                            break;

                        case "5":
                            Console.Clear();
                            Market();
                            break;

                        case "6":
                            return;

                        case "7":
                            Exit();
                            break;

                    }



                    static void Wallet()
                    {
                        
                        switch (Console.ReadLine())
                        {
                            case "1":
                                string money1 = Console.ReadLine();
                                int moneyInt;
                                if (int.TryParse(money1, out moneyInt) && moneyInt > 0)
                                {
                                    AccountProvider.AddMoney(moneyInt);
                                    SteamClient.ds.Save(AccountProvider.accounts, GameShop.AllGames);
                                    Console.WriteLine("Success");
                                    Console.ReadKey();
                                    return;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Somewhere misstake. Try again");
                                    return;
                                }
                            case "2":
                                return;
                        }                    
                    }

                    static void RegisterMM()
                    {
                        while (true)
                        {

                            Console.Clear();

                            Console.WriteLine("1.Change login\n" +
                                              "2.Chage nickname\n" +
                                              "3.Change password\n" +
                                              "4.Back");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("write login:");
                                    SteamClient.CurrentAccount.Login = Console.ReadLine();
                                    SteamClient.ds.Save(AccountProvider.accounts, GameShop.AllGames);
                                    Console.Clear();
                                    Console.WriteLine("success");
                                    Console.ReadKey();
                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("write nickname:");
                                    SteamClient.CurrentAccount.NickName = Console.ReadLine();
                                    SteamClient.ds.Save(AccountProvider.accounts, GameShop.AllGames);
                                    Console.Clear();
                                    Console.WriteLine("success");
                                    Console.ReadKey();
                                    break;

                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("write password:");
                                    SteamClient.CurrentAccount.Password = Console.ReadLine();
                                    SteamClient.ds.Save(AccountProvider.accounts, GameShop.AllGames);
                                    Console.Clear();
                                    Console.WriteLine("success");
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    return;

                            }

                            
                        }
                    }

                    static void Market()
                    {
                        while (true)
                        {
                            Console.WriteLine("Write game's name to buy it");
                            Console.WriteLine("Write \"back\" to back\n");
                            Console.WriteLine(GameShop.ShowGameMarket());
                            string gameInMarket = Console.ReadLine();
                            for (int i = 0; i < GameShop.AllGames.Count; i++)
                            {
                                Console.Clear();
                                if (gameInMarket == GameShop.AllGames[i].GameName)
                                {
                                    if (SteamClient.CurrentAccount.Wallet < GameShop.AllGames[i].GamePrice)
                                    {
                                        Console.WriteLine("Not enough money");
                                        break;
                                    }
                                    SteamClient.CurrentAccount.Wallet -= GameShop.AllGames[i].GamePrice;
                                    SteamClient.CurrentAccount.Games.Add(GameShop.AllGames[i]);    
                                    GameShop.AllGames[i].GamePrice = 0;
                                    SteamClient.ds.Save(AccountProvider.accounts, GameShop.AllGames);
                                    break;
                                }
                                if (gameInMarket == "back")
                                {
                                    return;
                                }
                            }
                            Console.ReadKey();
                        }
                    }

                    static void Exit()
                    {
                        SteamClient.ds.Save(AccountProvider.accounts, GameShop.AllGames);
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
                        Process.GetCurrentProcess().Kill();
                        return;
                    }
                }
            }
        }
    }
}
