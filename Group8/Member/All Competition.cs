using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group8
{
    public partial class All_Competition : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eSports_Club.mdf;Integrated Security=True";
        DataTable dtbl = new DataTable(); // Declare DataTable at the class level
        private string userEmail;
        private string userPw;

        public All_Competition(string email, string password)
        {
            InitializeComponent();
            this.Load += All_Competition_Load; // Subscribe to the Load event
            userEmail = email;
            userPw = password;
        }

        private void All_Competition_Load(object sender, EventArgs e)
        {
            // Add your code here to handle form load event
            // For example, you might want to populate some data or perform initialization tasks
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM competitions", sqlCon);
                // Fill the class-level DataTable dtbl
                sqlDa.Fill(dtbl);

                dgv1.DataSource = dtbl;
                dgv1.Columns["name"].Visible = false;
                dgv1.Columns["results"].Visible = false;
                dgv1.Refresh();

                dgv2.DataSource = dtbl;
                dgv2.Columns["name"].Visible = false;
                dgv2.Columns["date"].Visible = false;
                dgv2.Columns["time"].Visible = false;
                dgv2.Columns["location"].Visible = false;
                dgv2.Columns["pic"].Visible = false;
                dgv2.Columns["contact_num"].Visible = false;
                dgv2.Refresh();
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroups.SelectedItem != null) // Check if an item is selected
            {
                // Get the selected group name from the ComboBox
                string selectedGroupName = comboBoxGroups.SelectedItem.ToString();

                // Filter the DataTable to only include rows with the selected group name
                var query = dtbl.AsEnumerable()
                                .Where(row => row.Field<string>("group_name") == selectedGroupName);

                if (query.Any())
                {
                    // If there are matching rows, create a new DataTable with the filtered rows
                    DataTable filteredDataTable = query.CopyToDataTable();

                    // Update the DataGridView with the filtered DataTable
                    dgv2.DataSource = filteredDataTable;
                }
                else
                {
                    // If no matching rows found, clear the DataGridView
                    dgv2.DataSource = null;
                }
                dgv2.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userEmail, userPw);
            form1.Show();
            this.Hide();
        }
        
    }
}
