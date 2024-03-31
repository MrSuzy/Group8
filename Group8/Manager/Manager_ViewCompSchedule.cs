
using System;
using System.Collections;
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
    public partial class Manager_ViewCompSchedule : Form
    {
        private string userEmail;
        private string userPw;

        Manager manager;
        string target_comp;
        string comp_date;
        string comp_time;
        string comp_pic;
        string comp_cn;
        string comp_loc;

        public Manager_ViewCompSchedule(Manager manager, string email, string password)
        {
            InitializeComponent();
            this.manager = manager;
            userEmail = email;
            userPw = password;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_EditCompSche New_Edit_Competition_Schedule = new Manager_EditCompSche(manager, target_comp, comp_date, comp_time, comp_pic, comp_cn, comp_loc, userEmail, userPw);
            New_Edit_Competition_Schedule.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string comp_name = lblinfoCompT.Text;
            string comp_date = lblinfoDate.Text;
            string comp_time = lblinfoTime.Text;
            string comp_pic = lblinfoPIC.Text;
            string comp_cn = lblinfoCN.Text;
            string comp_loc = lblinfoLoc.Text;
            manager.Competition_Delete(comp_name, comp_date, comp_time, comp_pic, comp_cn, comp_loc);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_AddComp New_Add_or_Edit_Competition = new Manager_AddComp(manager);
            New_Add_or_Edit_Competition.ShowDialog();
        }

        private void Manager_ViewCompSchedule_Load(object sender, EventArgs e)
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
            comp_date = lblinfoDate.Text.ToString();
            comp_time = lblinfoTime.Text;
            comp_pic = lblinfoPIC.Text;
            comp_cn = lblinfoCN.Text;
            comp_loc = lblinfoLoc.Text;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
