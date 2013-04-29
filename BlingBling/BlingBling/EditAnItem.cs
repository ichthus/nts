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
    public partial class EditAnItem : Form
    {
        private BudgetItem _budgItem;

        public EditAnItem(BudgetItem item)
        {
            InitializeComponent();
            _budgItem = item;

            // fill in text boxes with current BudgetItem attributes
            AmountTextBox.Text = _budgItem.Amt.ToString();
            CategoryList.Text = _budgItem.Category;
            DescriptionTextBox.Text = _budgItem.Description;
            dateTimePicker1.Text = _budgItem.Date.ToString(); 
        }

        private void EditAnItem_Load(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                _budgItem.Amt = float.Parse(AmountTextBox.Text);
                _budgItem.Category = CategoryList.Text;
                _budgItem.Description = DescriptionTextBox.Text;
                _budgItem.Date = Convert.ToDateTime(dateTimePicker1.Text);
                // save in DB
                SuccessTextBox.Text = "Item successfully edited!"; // needs an if statement
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
    }
}
