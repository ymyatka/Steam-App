using Steam.Aplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Steam.Aplication
{
    public static class AccountProvider
    {
        public static List<Account> accounts = new List<Account>();

        public static string AddMoneyToAccount(string money)
        {
            if (int.TryParse(money, out _) && int.Parse(money) > 0)
            {
                int.Parse(money);
                AddMoney(int.Parse(money));
                SteamClient.ds.Save(accounts, GameShop.AllGames);
                return "Success";
            }
            else
            {
                return "Some where mistake. Please, try again";
            }
        }

        public static bool SignIn(string login, string password)
        {
            Account account = accounts.Where(a => a.Login == login && a.Password == password).FirstOrDefault();

            if (account == null)
            {
                return false;
            }
            
            SteamClient.CurrentAccount = account;
            return true;
        }

        public static string Register(string login, string nickName, string password)
        {
            string offense = null;

            if (login == offense)
            {
                return "This login can offense someone. Please, don't be a toxic and write something else";
            }
            if (CheckLogin(login))
            {            
                return "This login is already exist. Try anything else";
            }
            if (login.Length > 20 || login.Length < 5)
            {
                return "Pasword has to has more than 5 symbols and less than 20 symbols. Try again";
            }
            if (password.Length < 5 || password == null)
            {
                return "Password too small. Try different";
            }

            accounts.Add(new Account(nickName,login,password));

            SteamClient.ds.Save(accounts, GameShop.AllGames);

            return "success";
        }

        public static string ChangeLogin(string login)
        {
            string offense = null;

            if (login == offense)
            {
                return "This login can offense someone. Please, don't be a toxic and write something else";
            }
            if (CheckLogin(login))
            {
                return "This login is already exist. Try anything else";
            }
            if (login.Length > 20 || login.Length < 5)
            {
                return "Login has to has more than 5 symbols and less than 20 symbols. Try again";
            }

            SteamClient.CurrentAccount.Login = login;

            SteamClient.ds.Save(accounts, GameShop.AllGames);

            return "success";
        }

        public static string ChangeNickname(string nickName)
        {
            string offense = null;

            if (nickName == offense)
            {
                return "This nickname can offense someone. Please, don't be a toxic and write something else";
            }

            SteamClient.CurrentAccount.NickName = nickName; 

            SteamClient.ds.Save(accounts, GameShop.AllGames);

            return "success";
        }

        public static string ChangePassword(string password)
        {
            if (password.Length < 5 || password == null)
            {
                return "Password too small. Try different";
            }

            SteamClient.CurrentAccount.Password = password;

            SteamClient.ds.Save(accounts, GameShop.AllGames);

            return "success";
        }

        public static string WalletInfo()
        {          
            return SteamClient.CurrentAccount.Wallet.ToString() + "$" + "\n1.Add money\n" + "2.Back";
        }

        public static void AddMoney(int money)
        {
            SteamClient.CurrentAccount.Wallet += money;
        }

        public static string AccountInfo()
        {
            if (SteamClient.CurrentAccount == null)
            {
                return "Account is not exist. Try again";
            }
            return "Login: " + SteamClient.CurrentAccount.Login + "\nNickname: " + SteamClient.CurrentAccount.NickName + "\nPassword: " + SteamClient.CurrentAccount.Password;
        }

        public static bool CheckLogin(string login)
        {
            return accounts.Where(a => a.Login == login).FirstOrDefault() != null;
        }

        public static bool CheckAccount(string login, string password)
        {
            return accounts.Where(a => a.Login == login && a.Password == password).FirstOrDefault() != null;
        }

    }
}
