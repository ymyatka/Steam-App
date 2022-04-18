using Steam.Aplication;
using Steam.Aplication.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Steam.WinForms.Views.MainForm
{
    public partial class GameInfo : UserControl
    {
        Game game;

        public GameInfo(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void GameInfo_Load(object sender, EventArgs e)
        {
            GameImagePB.Image = Image.FromFile(Path.Combine(SteamClient.ds.pathToImages, game.PicturePath));
            GameImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
            gameDiscribeLB.Text = game.Discribe;
            gameNameLB.Text = game.GameName;
            if (SteamClient.CurrentAccount.Games.Where(i => game.GameName == i.GameName).FirstOrDefault() != null)
            {
                gamePriceLB.Text = "Куплено";
            }
            else
            {
                gamePriceLB.Text = game.GamePrice.ToString();
            }
        }

        private void BuyGameBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GameShop.BuyGame(game));
        }
    }
}
