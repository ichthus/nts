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

                int ukey = 2;
                string command="insert into nts_budget_items(`userkey`, `date`, `name`, `amount`) values("+ukey+",\""+dateTimePicker1.Text+"\",\""+DescriptionTextBox.Text+"\","+ float.Parse(AmountTextBox.Text)+");";
                
       
          
                sqlConn.Open();

                sqlDoReport.CommandText = command;
             
                sqlConn.Close();

                // alert user that item was successfully added to DB - this needs an if statement!
                SuccessTextBox.Text="Item successfully added to your budget!";

                // reset window
                dateTimePicker1.ResetText();
                CategoryMenu.ResetText();
                DescriptionTextBox.ResetText();
                AmountTextBox.ResetText();
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

        }
    


       
    }
}
