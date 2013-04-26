using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;

namespace BlingBling
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form w = null;
            if (UsernameTextBox.Text == "admin")
            {
                w = new WelcomeAdmin();
            }
            else
            {
                w = new WelcomePage();
            }
            //on successful login
            this.Hide();
            w.ShowDialog();
            this.Close();
        }

    }
}
