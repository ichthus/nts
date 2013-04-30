using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Data.SqlClient;

namespace BlingBling
{
    public partial class EditUser : Form
    {
        private int ukey;

        public EditUser()
        {
            InitializeComponent();
        }

        private void searchButton(object sender, EventArgs e)
        {
            string uname = button1.Text;
            string sqlqry = "SELECT * FROM nts_users WHERE nts_users.username = '" + UsernameEntryBox.Text + "';";
            SQLiteDataReader sqldr;
            errSearch.Clear();
            sqlConn.Open();
            sqlDoCmd.CommandText = sqlqry;

            sqldr = sqlDoCmd.ExecuteReader();

            //MessageBox.Show(sqlqry);
            if (!sqldr.HasRows)
            {
                UsernameEntryBox.Text = "";
                errSearch.SetError(UsernameEntryBox, "Sorry, but we couldn't find your username.");
                sqldr.Close();
                sqlConn.Close();
                return;
            }
            sqldr.Read();
            //MessageBox.Show(sqldr.GetString(1));
            nameTextBox.Text = sqldr.GetString(3);
            UsernameTextBox.Text = sqldr.GetString(1);
            ukey = sqldr.GetInt32(0);
            nameLabel.Visible = true;
            nameTextBox.Visible = true;
            UsernameLabel.Visible = true;
            UsernameTextBox.Visible = true;
            PasswordLabel.Visible = true;
            PasswordTextBox.Visible = true;
            PasswordLabel2.Visible = true;
            PasswordTextBox2.Visible = true;
            EditButton.Visible = true;


            sqldr.Close();
            sqlConn.Close();

        }

        private void editButton(object sender, EventArgs e)
        {
            string sqlquery = "";
            string rname = nameTextBox.Text;
            string uname = UsernameTextBox.Text;
            string pwd = PasswordTextBox.Text;
            /*
            if (PasswordTextBox.Text != "")
            {
                if (PasswordTextBox.Text != PasswordTextBox2.Text)
                {
                    errPwd.SetError(PasswordTextBox2, "Passwords do not match");
                    return;
                }

                sqlquery = "UPDATE nts_users SET username = '" + uname + "', password = '" + pwd + "', realname = '" + rname + "' WHERE userkey = " + ukey + ";";
            }
            else
            {
                sqlquery = "UPDATE nts_users SET username = '" + uname + "', realname = '" + rname + "' WHERE userkey = " + ukey + ";";
            }**/
            //sqlquery = "UPDATE nts_users SET realname = 'Crack Bandit' WHERE userkey=2;";
            //MessageBox.Show(sqlquery);
            sqlConn.Open();
            sqlDoCmd.CommandText = sqlquery;
            sqlConn.Close();

            nameTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            PasswordTextBox2.Text = "";
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            UsernameLabel.Visible = false;
            UsernameTextBox.Visible = false;
            PasswordLabel.Visible = false;
            PasswordTextBox.Visible = false;
            PasswordLabel2.Visible = false;
            PasswordTextBox2.Visible = false;
            EditButton.Visible = false;
            

        }

        private void cancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
