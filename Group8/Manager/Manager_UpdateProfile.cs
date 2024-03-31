
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
    public partial class Manager_UpdateProfile : Form
    {
        private string userEmail;
        private string userPw;
        public Manager_UpdateProfile(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }





        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.Show();
            this.Hide();
        }

        private void Manager_UpdateProfile_Load(object sender, EventArgs e)
        {
            Load_Details(userEmail, userPw);
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newEmail = txtEmail.Text;
            string newContact = txtCN.Text;
            string newPassword = txtPassword.Text;


            Manager manager = new Manager();
            bool success = manager.Update_Manager_Profile(userEmail, newEmail, newContact, newPassword);

            if (success)
            {
                MessageBox.Show("Successfully update Profile.");
                Load_Details(userEmail, userPw);
            }
            else
            {
                MessageBox.Show("Failed to update Profile.");            }
        }

        private void Load_Details(string userEmail, string userPw)
        {
            user_login login = new user_login();
            Dictionary<string, object> userinfo = login.Search_User(userEmail, userPw);
            if (userinfo != null)
            {
                lblinfoName.Text = userinfo["name"].ToString();
                lblinfoIC.Text = userinfo["ic"].ToString();
                lblinfouserID.Text = userinfo["id"].ToString();
                txtEmail.Text = userinfo["email"].ToString();
                txtCN.Text = userinfo["contactNo"].ToString();
                txtPassword.Text = userinfo["password"].ToString();
            }
            else
            {
                MessageBox.Show("Failed to load details.");
                return;
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
