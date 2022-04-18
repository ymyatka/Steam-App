using System;
using System.Collections.Generic;
using System.Text;

namespace Steam.Aplication
{
    public class Game
    {
        public string GameName { get; set; }

        public int GamePrice { get; set; }

        public string PicturePath { get; set; }

        public string Discribe { get; set; }

        public bool IsDeleted { get; set; } = false;

        public Game(string gameName, int gamePrice, string picturePath, string discribe)
        {
            GameName = gameName;
            GamePrice = gamePrice;
            PicturePath = picturePath;
            Discribe = discribe;
        }

        public Game(string gameName)
        {
            this.GameName = gameName;
        }

        public Game() { }

    }
}
