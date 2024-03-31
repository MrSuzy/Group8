
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
    public partial class Manager_StuList_Recom : Form
    {
        private string userEmail;
        private string userPw;


        Manager manager;
        string target_student;
        string student_name;
        string game;
        string peroformance_score;

        public Manager_StuList_Recom(Manager manager, string email, string password)
        {
            InitializeComponent();
            this.manager = manager;
            userEmail = email;
            userPw = password;

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.Show();
            this.Hide();
        }

        private void Manager_StuList_Recom_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT name FROM recommendation";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable recommendation = new DataTable();
            dataAdapter.Fill(recommendation);
            for (int i = 0; i < recommendation.Rows.Count; i++)
            {
                listBoxStudent.Items.Add(recommendation.Rows[i]["name"].ToString());
            }
            connection.Close();
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            target_student = listBoxStudent.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM recommendation WHERE name = @name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", target_student);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable competition_load = new DataTable();
            adapter.Fill(competition_load);
            lblinfoName.Text = string.Empty;
            lblinfoGame.Text = string.Empty;
            lblinfoPerformance.Text = string.Empty;
            connection.Close();
            lblinfoName.Text = competition_load.Rows[0]["name"].ToString();
            lblinfoGame.Text = competition_load.Rows[0]["game"].ToString();
            lblinfoPerformance.Text = competition_load.Rows[0]["performance_score"].ToString();
            student_name = lblinfoName.Text;
            game = lblinfoGame.Text;
            peroformance_score = lblinfoPerformance.Text;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
