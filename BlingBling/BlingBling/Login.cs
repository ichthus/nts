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

        private void LoginPage_Load(object sender, EventArgs e) { }


        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          SQLiteDataReader sqldr;
          SHA512 shaM = new SHA512Managed();
          Form w = null;

          sqlConn.Open();
          errLogin.Clear();

          string phash = GetSHA512Hash(shaM, PasswordTextBox.Text);

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
          //on successful login
          sqldr.Close(); 
          sqlConn.Close();
          this.Hide();
          w.ShowDialog();
          this.Close();
        }

        static string GetSHA512Hash(SHA512 sha512Hash, string input)
        {

          // Convert the input string to a byte array and compute the hash. 
          byte[] data = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

          // Create a new Stringbuilder to collect the bytes 
          // and create a string.
          StringBuilder sBuilder = new StringBuilder();

          // Loop through each byte of the hashed data  
          // and format each one as a hexadecimal string. 
          for (int i = 0; i < data.Length; i++)
          {
            sBuilder.Append(data[i].ToString("x2"));
          }

          // Return the hexadecimal string. 
          return sBuilder.ToString();
        }

        // Verify a hash against a string. 
        static bool VerifySHA512Hash(SHA512 sha512Hash, string input, string hash)
        {
          // Hash the input. 
          string hashOfInput = GetSHA512Hash(sha512Hash, input);

          // Create a StringComparer an compare the hashes.
          StringComparer comparer = StringComparer.OrdinalIgnoreCase;

          if (0 == comparer.Compare(hashOfInput, hash))
          {
            return true;
          }
          else
          {
            return false;
          }
        }

    }

   



}



