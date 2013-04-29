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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
          BeginDateTimePicker.Text = DateTime.Now.AddMonths(-1).ToString();
          RunReport();
          BeginDateTimePicker.MaxDate = DateTime.Now;
          EndDateTimePicker.MinDate = DateTime.Now.AddMonths(-1);

        }

        private void BeginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          EndDateTimePicker.MinDate = BeginDateTimePicker.Value;
          RunReport();
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          BeginDateTimePicker.MaxDate = EndDateTimePicker.Value;          
          RunReport();
        }

        private void RunReport()
        {
          string command = "select * from nts_budget_items where `date` > " + BeginDateTimePicker.Value.ToString("yyyyMMdd") + " and `date` < " + EndDateTimePicker.Value.ToString("yyyyMMdd") + ";";
          SQLiteDataReader reader;
          
          sqlConn.Open();

          sqlDoReport.CommandText = command;
          reader = sqlDoReport.ExecuteReader();
          ResultsGrid.DataSource = reader;
          reader.Close();
          sqlConn.Close();
        }
    }
}
