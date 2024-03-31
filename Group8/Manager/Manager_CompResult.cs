
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
    public partial class Manager_CompResult : Form
    {
        private string userEmail;
        private string userPw;


        Manager manager;
        string target_comp;
        string target_group;
        string comp_date;
        string comp_time;
        string comp_pic;
        string comp_cn;
        string comp_result;

        public Manager_CompResult(Manager manager, string email, string password)
        {
            InitializeComponent();
            this.manager = manager;
            userEmail = email;
            userPw = password;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.Show();
            this.Hide();
        }

        private void Manager_CompResult_Load(object sender, EventArgs e)
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

            string query_grpname = "SELECT DISTINCT group_name FROM competitions";
            SqlCommand command = new SqlCommand(query_grpname, connection);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
            DataTable competitions = new DataTable();
            DataAdapter.Fill(competitions);
            for (int i = 0; i < competitions.Rows.Count; i++)
            {
                comboBoxGrp.Items.Add(competitions.Rows[i]["group_name"].ToString());
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
            lblinfoDate.Text = string.Empty;
            lblinfoTime.Text = string.Empty;
            lblinfoPIC.Text = string.Empty;
            lblinfoCN.Text = string.Empty;
            connection.Close();
            lblinfoDate.Text = Convert.ToDateTime(competition_load.Rows[0]["date"]).ToString("dd-MM-yyyy");
            lblinfoTime.Text = competition_load.Rows[0]["time"].ToString();
            lblinfoPIC.Text = competition_load.Rows[0]["pic"].ToString();
            lblinfoCN.Text = competition_load.Rows[0]["contact_num"].ToString();
         }

        private void comboBoxGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            target_group = comboBoxGrp.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM competitions WHERE group_name = @group_name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@group_name", target_group);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable competition_load = new DataTable();
            adapter.Fill(competition_load);
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string comp_name = comboBoxCompT.Text;
            string comp_date = lblinfoDate.Text;
            string comp_time = lblinfoTime.Text;
            string comp_pic = lblinfoPIC.Text;
            string comp_cn = lblinfoCN.Text;
            string comp_result = comboBoxGrp.Text;
            manager.Update_Result(comp_name, comp_date, comp_time, comp_pic, comp_cn, comp_result);
            
        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
