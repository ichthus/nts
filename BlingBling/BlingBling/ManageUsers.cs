using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlingBling
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
          Form w = new DeleteUser();
          this.Hide();
          w.ShowDialog();
          this.Show();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
          Form w = new EditUser();
          this.Hide();
          w.ShowDialog();
          this.Show();

        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            Form w = new CreateUser();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }
    }
}
