using Steam.Aplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Steam.WinForms.Views.MainForm
{
    public partial class LibraryGameInfo : UserControl
    {
        Game game;

        public LibraryGameInfo(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void LibraryGameInfo_Load(object sender, EventArgs e)
        {
            GameNameLb.Text = game.GameName;
            DiscribeLb.Text = game.Discribe;
            GameImagePB.Image = Image.FromFile(Path.Combine(SteamClient.ds.pathToImages, game.PicturePath));
            GameImagePB.SizeMode = PictureBoxSizeMode.StretchImage;            
        }

        private void DelGameBtn_Click(object sender, EventArgs e)
        {
            SteamClient.CurrentAccount.DelGame(game);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            switch (game.GameName)
            {
                case "World of Warcraft":
                    Process.Start("");
                    break;
                case "Diablo III":
                    Process.Start(@"D:\ConsoleApp1\Steam.WinForms\Saves\Images\OjWZNZJq68RTeqtrHaCOmA.jpeg");
                    break;
                case "Dota 2":
                    Process.Start(@"D:\ConsoleApp1\Steam.WinForms\Saves\Images\image8.jpg");
                    break;
                case "Shrek 2":
                    Process.Start(@"D:\ConsoleApp1\Steam.WinForms\Saves\Images\Shrek_2_Game.jpg");
                    break;
                case "Dead Cells":
                    Process.Start(@"D:\ConsoleApp1\Steam.WinForms\Saves\Images\pnjK6Xqx59YcshdLmDvqrQ.jpeg");
                    break;
                case "Hollow Knight":
                    Process.Start(@"D:\ConsoleApp1\Steam.WinForms\Saves\Images\hollow-knight.jpg");
                    break;
            }

           
        }
    }
}
