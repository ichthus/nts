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
    public partial class BudgetWizard : Form
    {
        public BudgetWizard()
        {
            InitializeComponent();
        }

        private void BudgetWizard_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form w = new AddItem();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form w = new EditItem();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
