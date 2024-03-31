using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8
{
    public partial class Suggestion_to_Admin : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\eSports_Club.mdf;Integrated Security=True";
        private string userEmail;
        private string userPw;

        public Suggestion_to_Admin(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into feedbacks values (@name,@feedback)",con);
            cmd.Parameters.AddWithValue("@name", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@feedback", maskedTextBox2.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Sent to Admin!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userEmail, userPw);
            form1.Show();
            this.Hide();
        }

       

        private void feedbacksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Suggestion_to_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eSports_ClubDataSet.feedbacks' table. You can move, or remove it, as needed.

        }

        private void feedbacksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
