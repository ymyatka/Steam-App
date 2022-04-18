using Steam.Aplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steam.WinForms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AccountProvider.Register(RegLoginTB.Text, RegNickNameTB.Text, RegPasswordTB.Text));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Login().Show();

        }
    }
}
