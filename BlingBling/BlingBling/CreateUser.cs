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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
          passhasher ph = new passhasher();
          string phash = ph.GetSHA512Hash(PasswordTextBox.Text);
          string command = "select * from nts_users where `username` = '"+UsernameTextBox.Text+"';";
          SQLiteDataReader reader;
          
          errorChecker.Clear();

          if (PasswordTextBox.Text != PasswordTextBox2.Text)
          {
            errorChecker.SetError(PasswordTextBox2, "Passwords do not match.");
            return;
          }
          
          sqlConn.Open();
          sqlDoCreate.CommandText = command;
          reader = sqlDoCreate.ExecuteReader();

          if (reader.HasRows) 
          {
            errorChecker.SetError(UsernameTextBox, "Username already exists in the database.");
            reader.Close();
            sqlConn.Close();
            return;
          }

          reader.Close();

          command = "insert into nts_users (`username`,`password`,`realname`,`lastlogin`) values ( '"+UsernameTextBox.Text+"', '"+phash+"', '"+nameTextBox.Text+"', "+DateTime.Now.ToString("yyyyMMddHHmmss")+");";
          if (Admin.Checked == true)
          {
            command += "insert into nts_admins(`userkey`) values (last_insert_rowid());";
          }

          sqlDoCreate.CommandText = command;
          reader = sqlDoCreate.ExecuteReader();
          
          if (reader.RecordsAffected > 0)
          {
            MessageBox.Show("User created successfully!");
          }

          reader.Close();
          sqlConn.Close();
          this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
          string command = "select * from nts_users where username='" + UsernameTextBox.Text + "'";

          

        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_1234567890";
          if (charset.Contains(e.KeyChar.ToString()))
          {
          }
          else
          {
            e.Handled = true;
          }

        }

    }
}
