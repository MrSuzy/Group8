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
    public partial class EnrollAndPayment : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eSports_Club.mdf;Integrated Security=True";
        DataTable dtbl = new DataTable(); // Declare DataTable at the class level
        private string userEmail;
        private string userPw;


        public EnrollAndPayment(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userEmail, userPw);
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Enroll____Payment_Load(object sender, EventArgs e)
        {

        }

        Label labelPayable;



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Set default values for status and amount
            string status = "PAID";
            int amount = 120;

            // Open connection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Define SQL command with parameters

                string query = "INSERT INTO members_payment(member_id, name, payment_date) VALUES (@member_id, @name, @payment_date)";
                SqlCommand cmd = new SqlCommand(query, con);
                // Set parameter values
                cmd.Parameters.AddWithValue("@member_id", textBox2.Text);
                cmd.Parameters.AddWithValue("@name", textBox4.Text);
                cmd.Parameters.AddWithValue("@payment_date", DateTime.Now); // Assuming you want the current date
                //cmd.Parameters.AddWithValue("@status", status); // Set status to "paid"
                //cmd.Parameters.AddWithValue("@amount", amount); // Set amount to 120

                // Execute command
                cmd.ExecuteNonQuery();

                // Close connection
                con.Close();
            }

            MessageBox.Show("Payment and Enroll Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
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
