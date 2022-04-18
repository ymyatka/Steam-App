using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steam.Aplication.Models
{
    public static class GameShop
    {
        public static List<Game> AllGames = new List<Game>();

        public static string BuyGame(Game game)
        {
            Game gameFound = SteamClient.CurrentAccount.Games.Where(i => i.GameName == game.GameName).FirstOrDefault();

            if (gameFound != null && gameFound.IsDeleted)
            {
                gameFound.IsDeleted = false;
                SteamClient.ds.Save(AccountProvider.accounts, AllGames);          
                return "Game in library";
            }
            else if(gameFound != null)
            {
                return "You already have this game";
            }

            if (SteamClient.CurrentAccount.Wallet < game.GamePrice)
            {
                return "Not enough money";
            }
          
            SteamClient.CurrentAccount.Wallet -= game.GamePrice;
            SteamClient.CurrentAccount.Games.Add(game);
            SteamClient.ds.Save(AccountProvider.accounts, AllGames);
            return "Success";
        }
       
        public static string ShowGameMarket()
        {
            string oneGame = null;

            for (int i = 0; i < AllGames.Count; i++)
            {
                oneGame += AllGames[i].GameName + " " + AllGames[i].GamePrice.ToString() + "\n";
            }
            return oneGame;
        }
    }
}
