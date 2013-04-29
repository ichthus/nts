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
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
          Report newReport = new Report(Convert.ToDateTime(BeginDateTimePicker.Text), Convert.ToDateTime(EndDateTimePicker.Text));
          ResultBox.Text = newReport.process();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportPage_Load(object sender, EventArgs e)
        {
          BeginDateTimePicker.Text = DateTime.Now.AddMonths(-1).ToString();
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
