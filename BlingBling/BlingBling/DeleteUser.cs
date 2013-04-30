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
    public partial class DeleteUser : Form
    {
        private int ukey;

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            string sqlquery = "";
            string rname = nameTextBox.Text;
            string uname = UsernameTextBox.Text;
            
            
            //MessageBox.Show(sqlquery);
            sqlConn.Open();

            SQLiteDataReader reader;
            sqlquery = "DELETE FROM nts_budget_items WHERE userkey= " + ukey + ";";
            sqlDoCmd.CommandText = sqlquery;
            reader = sqlDoCmd.ExecuteReader();

            if (reader.RecordsAffected > 0)
                MessageBox.Show("User budget items successfully deleted!");
           

            reader.Close();

           
            sqlquery = "DELETE FROM nts_users WHERE userkey= " + ukey + ";";
            sqlDoCmd.CommandText = sqlquery;
            reader = sqlDoCmd.ExecuteReader();

            if (reader.RecordsAffected > 0)
                MessageBox.Show("User successfully deleted!");

            sqlConn.Close();

            UsernameEntryBox.Text = "";
            nameTextBox.Text = "";
            UsernameTextBox.Text = "";
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            UsernameLabel.Visible = false;
            UsernameTextBox.Visible = false;
            delButton.Visible = false;
            
        }

        private void SearchButton(object sender, EventArgs e)
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
                errSearch.SetError(UsernameEntryBox, "Sorry, but we couldn't find the username.");
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
            delButton.Visible = true;

            sqldr.Close();
            sqlConn.Close();
        }

        private void cancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
