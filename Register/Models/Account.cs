using System;
using System.Collections.Generic;
using System.Linq;

namespace Steam.Aplication
{
    public class Account
    {       
        public string NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Game> Games { get; set; }
        public int Wallet { get; set; }

        public Account(string nickName, string login, string password)
        {
            NickName = nickName;
            Login = login;
            Password = password;
            Games = new List<Game>();
        }

        public void DelGame(Game game)
        {
            Games.Where(i => i.GameName == game.GameName).FirstOrDefault().IsDeleted = true;
        }
    }
}
