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
            string bdate = BeginDateTimePicker.Value.ToString("yyyyMMdd");
            string edate = EndDateTimePicker.Value.ToString("yyyyMMdd");
            string query = "SELECT `bgtkey`, `date`, `name`, `amount`, `catkey` FROM nts_budget_items WHERE Date >= " + bdate + " AND Date <= " + edate + " and userkey = "+Properties.Settings.Default.userkey+";";
            // new connection?
            sqlConn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, sqlConn); 
           
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
         
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.ResultsGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("could not perform search");
            }
            //RunReport();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
          sqlConn.ConnectionString = Properties.Settings.Default.blingdb;

          BeginDateTimePicker.Text = DateTime.Now.AddMonths(-1).ToString();
          BeginDateTimePicker.MaxDate = DateTime.Now;
          EndDateTimePicker.MinDate = BeginDateTimePicker.Value;
          //RunReport();
        }

        private void BeginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          EndDateTimePicker.MinDate = BeginDateTimePicker.Value;
         // RunReport();
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          BeginDateTimePicker.MaxDate = EndDateTimePicker.Value;
          //RunReport();
        }

        private void RunReport()
        {
          string command = "select * from nts_budget_items where `date` >= " + BeginDateTimePicker.Value.ToString("yyyyMMdd") + " and `date` <= " + EndDateTimePicker.Value.ToString("yyyyMMdd") + ";";
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
