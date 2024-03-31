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
    public partial class Update_Profile : Form
    {
        public Update_Profile()
        {
            InitializeComponent();
        }

        // Implement the Load event handler for the form
        private void Update_Profile_Load(object sender, EventArgs e)
        {
            // Add your code to initialize the form or load data
        }

        // Implement the click event handler for button1 (Menu)
        private void button1_Click(object sender, EventArgs e)
        {
            // Add your code to handle the menu button click
        }

        // Implement the click event handler for button2 (Update)
        private void button2_Click(object sender, EventArgs e)
        {
            // Add your code to handle the update button click
        }

        // Implement the click event handler for button3 (Cancel)
        private void button3_Click(object sender, EventArgs e)
        {
            // Add your code to handle the cancel button click
        }

         private void button2_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eSports_Club.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE user_info SET name=@name, password=@password, email=@email WHERE contact_num=@contact_num", con))
                {
                    
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@contact_num", textBox4.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}