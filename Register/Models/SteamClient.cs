using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Steam.Aplication.Models;

namespace Steam.Aplication
{
    public static class SteamClient
    {
       
        public static Account CurrentAccount { get; set; }

        public static DataStorage ds = new DataStorage(Path.GetFullPath(Path.Combine(Path.Combine(AppContext.BaseDirectory, @"..\..\..\") ,"Saves")));

        public static string ShowGameLibrary()
        {
            string oneGame = null;

            for (int i = 0; i < CurrentAccount.Games.Count; i++)
            {
                oneGame += CurrentAccount.Games[i].GameName + "\n";
            }
            
            if(oneGame == null)
            {
                ds.Save(GameShop.AllGames);
                return "No one game here";
            }

            ds.Save(GameShop.AllGames);
            return oneGame;
        }

    }
}
