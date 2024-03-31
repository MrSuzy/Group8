using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmUpdateProfile : Form
    {
        private string userEmail;
        private string userPw;
        public frmUpdateProfile(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newEmail = txtEmail.Text;
            string newContact = txtContact.Text;
            string newPassword = txtPassword.Text;

            Coach coach = new Coach();
            bool success = coach.Profile_Update(userEmail, newEmail, newContact, newPassword); 

            if (success)
            {
                MessageBox.Show("Successfully update profile.");
                Load_Details(userEmail, userPw);
            }
            else
            {
                MessageBox.Show("Failed to update profile.");
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachMenu coachMenu = new frmCoachMenu(userEmail, userPw);
            coachMenu.Show();
            this.Close();
        }

        private void frmUpdateProfile_Load(object sender, EventArgs e)
        {
           Load_Details(userEmail, userPw);
        }

        private void Load_Details(string userEmail, string userPw)
        {
            user_login login = new user_login();
            Dictionary<string, object> userInfo = login.Search_User(userEmail, userPw);
            if (userInfo != null)
            {
                lblNameInfo.Text = userInfo["name"].ToString();
                lblICInfo.Text = userInfo["ic"].ToString();
                lblIDInfo.Text = userInfo["id"].ToString();
                txtEmail.Text = userInfo["email"].ToString();
                txtContact.Text = userInfo["contactNo"].ToString();
                txtPassword.Text = userInfo["password"].ToString();
            }
            else
            {
                MessageBox.Show("Failed to load details.");
                return;
            }
        }
    }
}
