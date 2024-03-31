
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
using System.Xml.Linq;

namespace Group8
{
    public partial class Manager_StudList_Comp : Form
    {
        private string userEmail;
        private string userPw;
        public Manager_StudList_Comp(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        string target_comp;

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.Show();
            this.Hide();
        }

        private void Manager_StudList_Comp_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT DISTINCT title FROM competitions";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable competition = new DataTable();
            dataAdapter.Fill(competition);
            for (int i = 0; i < competition.Rows.Count; i++)
            {
                comboBoxCompT.Items.Add(competition.Rows[i]["title"].ToString());
            }
            connection.Close();
        }
        private void comboBoxCompT_SelectedIndexChanged(object sender, EventArgs e)
        {
            target_comp = comboBoxCompT.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM competitions WHERE title = @title;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", target_comp);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable competition_load = new DataTable();
            adapter.Fill(competition_load);
            lblinfoCompT.Text = string.Empty;
            lblinfoDate.Text = string.Empty;
            lblinfoTime.Text = string.Empty;
            lblinfoPIC.Text = string.Empty;
            lblinfoCN.Text = string.Empty;
            lblinfoLoc.Text = string.Empty;
            connection.Close();
            lblinfoCompT.Text = competition_load.Rows[0]["title"].ToString();
            lblinfoDate.Text = Convert.ToDateTime(competition_load.Rows[0]["date"]).ToString("dd-MM-yyyy");
            lblinfoTime.Text = competition_load.Rows[0]["time"].ToString();
            lblinfoPIC.Text = competition_load.Rows[0]["pic"].ToString();
            lblinfoCN.Text = competition_load.Rows[0]["contact_num"].ToString();
            lblinfoLoc.Text = competition_load.Rows[0]["location"].ToString();
        }



        private void btnDone_Click(object sender, EventArgs e)
        {
            listBoxSpecificStu.Items.Clear();
            string selectedCompetitionTitle = comboBoxCompT.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT DISTINCT name FROM competitions WHERE title = @title;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", selectedCompetitionTitle);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable competition_load = new DataTable();
            adapter.Fill(competition_load);
            connection.Close();
            foreach (DataRow row in competition_load.Rows)
            {
                listBoxSpecificStu.Items.Add(row["name"].ToString());
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}

