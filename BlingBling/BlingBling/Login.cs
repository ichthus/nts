using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;

using System.Data.SQLite;
using System.Data.SqlClient;

namespace BlingBling
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e) 
        {
          sqlConn.ConnectionString = Properties.Settings.Default.blingdb;

        }


        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          SQLiteDataReader sqldr;
          passhasher ph = new passhasher();
          Form w = null;

          sqlConn.Open();
          errLogin.Clear();

          string phash = ph.GetSHA512Hash(PasswordTextBox.Text);

          string sqlstmt = "SELECT nts_users.username, nts_users.password, nts_users.realname, nts_users.lastlogin, nts_users.userkey, nts_admins.userkey AS admin FROM nts_users LEFT OUTER JOIN nts_admins ON nts_users.userkey = nts_admins.userkey where nts_users.username = '"+UsernameTextBox.Text+"' and nts_users.password = '"+phash+"'";

          sqlDoLogin.CommandText = sqlstmt.Replace("USERNAME_PARSE",UsernameTextBox.Text.ToLower()).Replace("PASSWORD_HASH", phash);
          
          sqldr = sqlDoLogin.ExecuteReader();

          //MessageBox.Show(sqlDoLogin.CommandText);
          if (!sqldr.HasRows)
          {
            PasswordTextBox.Text = "";
            errLogin.SetError(PasswordTextBox, "Sorry, but we couldn't find your username or password.");
            sqldr.Close();
            sqlConn.Close();
            return;
          }
          sqldr.Read();
          if (sqldr.IsDBNull(sqldr.GetOrdinal("admin")))
          {
            w = new WelcomePage();
          }
          else
          {
            w = new WelcomeAdmin();
          }
          Properties.Settings.Default.userkey = Convert.ToInt32(sqldr["userkey"]);
          //on successful login
          sqldr.Close(); 
          sqlConn.Close();
          this.Hide();
          w.ShowDialog();
          this.Close();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}



