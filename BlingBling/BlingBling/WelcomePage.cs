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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            
            Form w = new ReportPage();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }

        private void BudgetWizardButton_Click(object sender, EventArgs e)
        {
            Form w = new BudgetWizard();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }
    }
}
