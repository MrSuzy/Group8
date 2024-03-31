
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Group8
{
    public partial class Manager_AssignStudent : Form
    {
        private string userEmail;
        private string userPw;

        Manager manager;
        string target_student;
        string name;
        string game;
        string peroformance_score;
        string target_comp;

        public Manager_AssignStudent(Manager manager, string email, string password)
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

        private void Manager_AssignStudent_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query_title = "SELECT DISTINCT title FROM competitions";
            SqlCommand cmd = new SqlCommand(query_title, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable competition = new DataTable();
            dataAdapter.Fill(competition);
            for (int i = 0; i < competition.Rows.Count; i++)
            {
                comboBoxCompT.Items.Add(competition.Rows[i]["title"].ToString());
            }
            
            string query = "SELECT name FROM recommendation";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
            DataTable recommendation = new DataTable();
            DataAdapter.Fill(recommendation);
            for (int i = 0; i < recommendation.Rows.Count; i++)
            {
                listBoxStuName.Items.Add(recommendation.Rows[i]["name"].ToString());
            }
            connection.Close();
        }
        private void listBoxStuName_SelectedIndexChanged(object sender, EventArgs e)
        {
            target_student = listBoxStuName.SelectedItem.ToString();
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
            name = lblinfoName.Text;
            game = lblinfoGame.Text;
            peroformance_score = lblinfoPerformance.Text;
        }
        private void comboBoxStulist_SelectedIndexChanged(object sender, EventArgs e)
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
            string student_name = lblinfoName.Text;
            string game = lblinfoGame.Text;
            string performance_score = lblinfoPerformance.Text;
            string comp_name = lblinfoCompT.Text;
            string comp_date = lblinfoDate.Text;
            string comp_time = lblinfoTime.Text;
            string comp_pic = lblinfoPIC.Text;
            string comp_cn = lblinfoCN.Text;
            string comp_loc = lblLoc.Text; 
            manager.Assign_student(student_name, game, performance_score, comp_name, comp_date, comp_time, comp_pic, comp_cn, comp_loc);

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
