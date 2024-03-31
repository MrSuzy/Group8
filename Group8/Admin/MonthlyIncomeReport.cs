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
    public partial class MonthlyIncomeReport : Form
    {
        private admin_info admin;
        private SqlConnection connection;
        private string connectionString;
        private string userEmail;
        private string userPw;


        public MonthlyIncomeReport(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string coach_id = txtCoachID.Text;
            string month = cbMonth.SelectedItem.ToString();
            admin_info admin = new admin_info();
            List<Dictionary<string, object>> loadSalary = admin.GetMonthlySalary(coach_id, month);

            if (loadSalary != null && loadSalary.Count > 0)
            {
                lblMemberDetails.Text = loadSalary[0]["num_members"].ToString();
                lblTotalFeesDetails.Text = loadSalary[0]["total_fees"].ToString();
                lblClubFeesDetails.Text = loadSalary[0]["club_fee"].ToString();
                lblSalaryDetails.Text = loadSalary[0]["salary"].ToString();
            }  
            else
            {
                MessageBox.Show("Error viewing salary.");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(userEmail, userPw);
            adminMenu.Show();
            this.Hide();
        }
    }
}
