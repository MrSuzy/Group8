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
using System.Configuration;

namespace Group8
{
    public partial class ProfileUpdate : Form
    {
        private string userEmail;
        private string userPw;
        
        public ProfileUpdate(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }



        private void Load_Details(string userEmail, string userPw)
        {
            user_login login = new user_login();
            Dictionary<string, object> userInfo = login.Search_User(userEmail, userPw);
            if (userInfo != null)
            {
                lblNameDetails.Text = userInfo["name"].ToString();
                lblICDetails.Text = userInfo["ic"].ToString();
                lblUIDDetails.Text = userInfo["id"].ToString();
                txtEmail.Text = userInfo["email"].ToString();
                txtContact.Text = userInfo["contactNo"].ToString();
                txtPass.Text = userInfo["password"].ToString();
            }
            else
            {
                MessageBox.Show("Failed to load details.");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newEmail = txtEmail.Text;
            string newContact = txtContact.Text;
            string newPassword = txtPass.Text;

            admin_info admin = new admin_info();
            bool success = admin.Profile_Update(userEmail, newEmail, newContact, newPassword);

            if (success)
            {
                MessageBox.Show("Update profile sucessfully.");
                Load_Details(userEmail, userPw);
            }
            else
            {
                MessageBox.Show("Failed to update profile.");
            }
        }

        private void ProfileUpdate_Load(object sender, EventArgs e)
        {
            Load_Details(userEmail, userPw);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(userEmail, userPw);
            adminMenu.Show();
            this.Hide();
        }
    }
}
