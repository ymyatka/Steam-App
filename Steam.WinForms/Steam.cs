using Steam.Aplication;
using Steam.Aplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steam.WinForms
{
    public partial class Steam : Form
    {
        public Steam()
        {
            InitializeComponent();
        }

        private void Steam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            hostPanel.Controls.Clear();
            hostPanel.Controls.Add(new Views.MainForm.LibraryForm() { Dock = DockStyle.Fill });
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            hostPanel.Controls.Clear();
            hostPanel.Controls.Add(new Views.MainForm.AccountForm() { Dock = DockStyle.Fill });
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            hostPanel.Controls.Clear();
            hostPanel.Controls.Add(new Views.MainForm.MarketForm() { Dock = DockStyle.Fill });
        }
    }
}
