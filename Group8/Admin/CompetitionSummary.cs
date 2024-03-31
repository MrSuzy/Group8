using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Group8.admin_info;

namespace Group8
{
    public partial class CompetitionSummary : Form
    { 
        private admin_info admin;
        private string userEmail;
        private string userPw;

        public CompetitionSummary(string email, string password)
        {
            InitializeComponent();
            admin = new admin_info();
            userEmail = email;
            userPw = password;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DataTable data = admin.Search_Competition_By_Name(name);
            foreach (DataRow row in data.Rows)
            {
                lbSummary.Items.Add($"Group: {row["group_name"]}, Title: {row["title"]}, Result: {row["results"]}");
            }
            lblTotalWins.Text = $"Total Wins: {admin.GetTotalWins(name)}";
            lblTotalLoss.Text = $"Total Loss: {admin.GetTotalLosses(name)}";

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbSummary.Items.Clear();
            txtName.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(userEmail, userPw);
            adminMenu.Show();
            this.Hide();
        }
    }
}
