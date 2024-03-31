using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Group8
{
    public partial class Unenroll : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eSports_Club.mdf;Integrated Security=True";
        DataTable dtbl = new DataTable(); // Declare DataTable at the class level
        private string userEmail;
        private string userPw;

        public Unenroll(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void Unenroll_Load(object sender, EventArgs e)
        {
            // Add any initialization code here
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) // Check if an item is selected
            {
                // Get the selected group name from the ComboBox
                string selectedGame = comboBox1.SelectedItem.ToString();

                // Filter the DataTable to only include rows with the selected group name
                var query = dtbl.AsEnumerable()
                                .Where(row => row.Field<string>("game") == selectedGame);

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

        }

        private void UpdateLabels()
        {
            // Add logic to update labels here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userEmail, userPw);
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unenrolled successfully!");
        }


        private void label1_Click(object sender, EventArgs e)
        {
            // Add label1 click event logic here
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Add label2 click event logic here
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Add label3 click event logic here
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM training_schedule", sqlCon);
                // Fill the class-level DataTable dtbl
                sqlDa.Fill(dtbl);

                dgv1.DataSource = dtbl;

                dgv1.Refresh();

            }
        }
    }
}