using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8
{
    public partial class Training_Schedule : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eSports_Club.mdf;Integrated Security=True";
        DataTable dtbl = new DataTable(); // Declare DataTable at the class level
        DataSet ds = new DataSet();
        private string userEmail;
        private string userPw;


        public Training_Schedule(string email, string password)
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            userEmail = email;
            userPw = password;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Filter the DataTable to only include rows with the selected date
            var query = dtbl.AsEnumerable()
                            .Where(row => row.Field<DateTime>("date").Date == selectedDate);

            if (query.Any())
            {
                // If there are matching rows, create a new DataTable with the filtered rows
                DataTable filteredDataTable = query.CopyToDataTable();

                // Update the DataGridView with the filtered DataTable
                dgv1.DataSource = filteredDataTable;
            }
            else
            {
                // If no matching rows found, clear the DataGridView
                dgv1.DataSource = null;
            }
            dgv1.Refresh();
        }


        private void ClearDataGridViews()
        {
            dgv1.DataSource = null;
            dgv2.DataSource = null;
            dgv3.DataSource = null;
            dgv4.DataSource = null;
            dgv5.DataSource = null;
            dgv6.DataSource = null;
        }

        private void PopulateDataGridViews(DataRow[] selectedRows)
        {
            foreach (DataRow row in selectedRows)
            {
                // Determine which day of the week the row corresponds to
                DayOfWeek dayOfWeek = ((DateTime)row["date"]).DayOfWeek;
                DataGridView dgv = GetDataGridView(dayOfWeek);

                // Add the row to the corresponding DataGridView
                DataTable dt = dgv.DataSource as DataTable;
                if (dt == null)
                {
                    dt = selectedRows.CopyToDataTable();
                    dgv.DataSource = dt;
                }
                else
                {
                    dt.Rows.Add(row.ItemArray);
                }
            }
        }

        private DataGridView GetDataGridView(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return dgv1;
                case DayOfWeek.Tuesday:
                    return dgv2;
                case DayOfWeek.Wednesday:
                    return dgv3;
                case DayOfWeek.Thursday:
                    return dgv4;
                case DayOfWeek.Friday:
                    return dgv5;
                case DayOfWeek.Saturday:
                    return dgv6;
                default:
                    throw new ArgumentException("Invalid day of the week.");
            }
        }

        private void Training_Schedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userEmail, userPw);
            form1.Show();
            this.Hide();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear existing data from all DataGridViews
            dgv1.DataSource = null;
            dgv2.DataSource = null;
            dgv3.DataSource = null;
            dgv4.DataSource = null;
            dgv5.DataSource = null;
            dgv6.DataSource = null;

            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Calculate the start and end dates for the week (Monday to Saturday)
            DateTime startDate = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + (int)DayOfWeek.Monday);
            DateTime endDate = startDate.AddDays(5); // Saturday

            // Retrieve data from the database for the selected date range
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT * FROM training_schedule WHERE [date] BETWEEN @StartDate AND @EndDate";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Bind data to DataGridViews
                dgv1.DataSource = dtbl;
                dgv2.DataSource = dtbl.Copy(); // Clone the DataTable for each DataGridView
                dgv3.DataSource = dtbl.Copy();
                dgv4.DataSource = dtbl.Copy();
                dgv5.DataSource = dtbl.Copy();
                dgv6.DataSource = dtbl.Copy(); // DataGridView for Saturday

                // Refresh DataGridViews
                dgv1.Refresh();
                dgv2.Refresh();
                dgv3.Refresh();
                dgv4.Refresh();
                dgv5.Refresh();
                dgv6.Refresh();
            }
        }


    }
}
