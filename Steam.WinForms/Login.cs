using Steam.Aplication;
using Steam.Aplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam.WinForms
{
    public partial class Login : Form
    {
        public Login()
        {
            SteamClient.ds.Load(out AccountProvider.accounts, out GameShop.AllGames);
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (AccountProvider.SignIn(loginSpace.Text, passwordSpace.Text))
            {               
                new Steam().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {          
            new Register().Show();
            this.Hide();
        }
    }
}
