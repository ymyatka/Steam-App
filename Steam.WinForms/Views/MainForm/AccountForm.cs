using Steam.Aplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steam.WinForms.Views.MainForm
{
    public partial class AccountForm : UserControl
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            nameTB.Text = SteamClient.CurrentAccount.Login;
            passwordTB.Text = SteamClient.CurrentAccount.Password;
            nicknameTB.Text = SteamClient.CurrentAccount.NickName;
            moneyTB.Text = SteamClient.CurrentAccount.Wallet.ToString();
        }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {
            AccountProvider.ChangeLogin(nameTB.Text);
        }

        private void nicknameLabel_TextChanged(object sender, EventArgs e)
        {
            AccountProvider.ChangeNickname(nameTB.Text);
        }

        private void passwordLabel_TextChanged(object sender, EventArgs e)
        {
            AccountProvider.ChangePassword(passwordTB.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            SteamClient.CurrentAccount.Wallet = int.Parse(moneyTB.Text);
        }
    }
}
