using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8
{
    public partial class Performance_Record : Form
    {
        private string userEmail;
        private string userPw;
        private string connectionString;
        private SqlConnection connection;

        public Performance_Record(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
            connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void Performance_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eSports_ClubDataSet.players_performance' table. You can move, or remove it, as needed.
            this.players_performanceTableAdapter.Fill(this.eSports_ClubDataSet.players_performance);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userEmail, userPw);
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void players_performanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.players_performanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eSports_ClubDataSet);

        }
    }
}
