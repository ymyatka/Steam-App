using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Steam.Aplication.Models
{
    public class DataStorage
    {     
        public string pathToStorage = "";

        public string accountsPath = "Accounts.txt";

        public string gamesPath = "Games.txt";

        public string pathToImages = Path.GetFullPath(Path.Combine((Path.Combine(Path.Combine(AppContext.BaseDirectory, @"..\..\..\"), "Saves")),"Images"));

        public DataStorage(string pathToStorage)
        {
            this.pathToStorage = pathToStorage;

            if (!Directory.Exists(pathToStorage))
            {
                Directory.CreateDirectory(pathToStorage);
            }
            if (!File.Exists(Path.Combine(pathToStorage, accountsPath)))
            {
                File.Create(Path.Combine(pathToStorage, accountsPath));               
            }

            if (!Directory.Exists(pathToStorage))
            {
                Directory.CreateDirectory(pathToStorage);
            }
            if (!File.Exists(Path.Combine(pathToStorage, gamesPath)))
            {
                File.Create(Path.Combine(pathToStorage, gamesPath));
            }
        }

        public void Save(List<Account> accounts, List<Game> games)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(pathToStorage, accountsPath)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(accounts));
            }

            using (StreamWriter sw = new StreamWriter(Path.Combine(pathToStorage, gamesPath)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(games));
            }
        }

        public void Save(List<Account> accounts)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(pathToStorage, accountsPath)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(accounts));
            }

        }

        public void Save(List<Game> games)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(pathToStorage, gamesPath)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(games));
            }
        }


        public void Load(out List<Account> accounts, out List<Game> games)
        {
            Load(out accounts);
            Load(out games);
        } 
        
        public void Load(out List<Game> games)
        {
            using (StreamReader sr = new StreamReader(Path.Combine(pathToStorage, gamesPath)))
            {
                games = JsonConvert.DeserializeObject<List<Game>>(sr.ReadToEnd());
            }

            if (games == null)
            {
                games = new List<Game>()
                {
                new Game("World of Warcraft", 500, "WoWP.jpg","Гринд"),
                new Game("Hollow Knight", 300, "hollow-knight.jpg","Бест гейм евер(кроме шрека)"),
                new Game("Diablo III", 666, "OjWZNZJq68RTeqtrHaCOmA.jpeg","Фиг знает что, просто так вставил"),
                new Game("Dota 2", 0,"image8.jpg" , "Ну дота и дота, чё бубнеть то?"),
                new Game("Shrek 2", 999999999, "Shrek_2_Game.jpg", "религия"),
                new Game("Dead Cells", 150, "pnjK6Xqx59YcshdLmDvqrQ.jpeg","Клетка в клетке")
                };
            }
                
        }

        public void Load(out List<Account> accounts)
        {
            using (StreamReader sr = new StreamReader(Path.Combine(pathToStorage, accountsPath)))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(sr.ReadToEnd());

                if (accounts == null)
                {
                    accounts = new List<Account>();
                }
            }
        }
    }
}
