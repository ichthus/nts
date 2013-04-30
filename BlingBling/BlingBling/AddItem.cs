using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.Data.SQLite;

namespace BlingBling
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
          //MessageBox.Show(CategoryMenu.Text);


            if (checkInput())
            {
                // create a new BudgetItem
                BudgetItem newItem = new BudgetItem
                    (Convert.ToDateTime(dateTimePicker1.Text), CategoryMenu.Text, DescriptionTextBox.Text, float.Parse(AmountTextBox.Text));

                // add item to DB

                int ukey = Properties.Settings.Default.userkey;
                string command="insert into nts_budget_items(`userkey`, `date`, `name`, `amount`, `catkey`) values("+ukey+", "+dateTimePicker1.Value.ToString("yyyyMMdd")+",\""+DescriptionTextBox.Text+"\","+ AmountTextBox.Text+", "+CategoryMenu.SelectedValue+");";
                sqlConn.Open();
                SQLiteDataReader reader;
                
                sqlDoReport.CommandText = command;

                reader = sqlDoReport.ExecuteReader();
                
                sqlConn.Close();

                // alert user that item was successfully added to DB - this needs an if statement!
                if (reader.RecordsAffected > 0)
                {
                  SuccessTextBox.Text = "Item successfully added to your budget!";
                }
                else
                {
                  SuccessTextBox.Text = "There has been an error in adding your item.";
                }
                // reset window
                dateTimePicker1.ResetText();
                CategoryMenu.ResetText();
                DescriptionTextBox.ResetText();
                AmountTextBox.ResetText();
                CategoryMenu.ClearSelected();
            }
            
               
        
        }

       private bool checkInput()
        {
            String amt = AmountTextBox.Text;
            String des = DescriptionTextBox.Text;
            bool _is;

            try
            {
                if (float.Parse(amt) < 0)
                {

                    SuccessTextBox.Text = ("Amount must be a positive number!");
                    _is = false;
                }
                else if (amt == "" || des == "")
                {
                    SuccessTextBox.Text = "Please enter all fields.";
                    _is = false;
                }
                else
                    _is = true;

            }
            catch (Exception e)
            {
                SuccessTextBox.Text = ("Amount must be a number!");
                    _is = false;
            }
            return _is;
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
          
          sqlConn.ConnectionString = Properties.Settings.Default.blingdb;


          SQLiteDataReader reader = null;
          /*
               catkey INTEGER PRIMARY KEY AUTOINCREMENT,
               income INTEGER NOT NULL,
               name VARCHAR(50) NOT NULL,
               descr TEXT
          */
          string command = "select `catkey`, `name` from nts_budget_category where `income` = 0;";
          sqlConn.Open();


          sqlDoReport.CommandText = command;
          reader = sqlDoReport.ExecuteReader();

          CategoryMenu.BeginUpdate();
 
          ArrayList categories = new ArrayList();
          //int i;
          //string s = "";
          //while (reader.Read())
          //{
          //  i = (int)(reader[1]);
          //  s = (string)(reader[2]);
          //  MessageBox.Show(s);

          //  categories.Add(new BudgetCategory(i, s));
          //}
          //MessageBox.Show("test");
          categories.Add(new BudgetCategory(1, "Income"));
          categories.Add(new BudgetCategory(2, "Bills"));
          categories.Add(new BudgetCategory(3, "Groceries"));
          categories.Add(new BudgetCategory(4, "Electricity"));
          categories.Add(new BudgetCategory(5, "Rent/Mortgage"));
          categories.Add(new BudgetCategory(6, "Entertainment"));
          categories.Add(new BudgetCategory(7, "Phone"));
          CategoryMenu.DataSource = categories;
          CategoryMenu.DisplayMember = "Text";
          CategoryMenu.ValueMember = "Value";
          //CategoryMenu.Sorted = true;
          CategoryMenu.EndUpdate();

          CategoryMenu.ClearSelected();

          reader.Close();
          sqlConn.Close();
        }
    }
}
