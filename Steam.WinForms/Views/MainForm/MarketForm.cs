using Steam.Aplication;
using Steam.Aplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steam.WinForms.Views.MainForm
{
    public partial class MarketForm : UserControl
    {
        public MarketForm()
        {
            InitializeComponent();
        }

        private void MarketForm_Load(object sender, EventArgs e)
        {
            int StartX = -200;

            int LocationX = -200;

            int LocationY = -52;

            for (int i = 0; i < GameShop.AllGames.Count; i++)
            {
                PictureBox pictureBox1 = new PictureBox();
                if(GameShop.AllGames[i].PicturePath == null)
                {
                    continue;
                }

                if (i % 3 == 0)
                {
                    LocationY += 119;
                    LocationX = StartX;
                }

                pictureBox1.Location = new Point(LocationX += 250, LocationY);
                pictureBox1.Name = GameShop.AllGames[i].GameName;
                pictureBox1.Size = new Size(191, 99);
                pictureBox1.Image = Image.FromFile(Path.Combine(SteamClient.ds.pathToImages,GameShop.AllGames[i].PicturePath));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Click += new EventHandler(Game_Click);

                this.Controls.Add(pictureBox1);
            }

        }

        private void Game_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            Game game = GameShop.AllGames.Where(i => pictureBox.Name == i.GameName).FirstOrDefault();

            if (game != null)
            {
                Controls.Clear();
                Controls.Add(new GameInfo(game) { Dock = DockStyle.Fill });
            }
        }
    }
}
