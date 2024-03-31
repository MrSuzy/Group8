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
    public partial class EditUser : Form
    {
        private admin_info admin;
        // private string user_id;
        private string[] userInfo;
        private string userEmail;
        private string userPw;

        public EditUser(string[] userInfo, string email, string password)
        {
            InitializeComponent();
            // this.user_id = user_id;
            this.userInfo = userInfo;
            admin = new admin_info();
            userEmail = email;
            userPw = password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // string user_id = lblUIDDetails.Text;
            string email = txtEmail.Text;
            string contact_num = txtContact.Text;
            string password = txtPass.Text;
            string level = cbLevel.SelectedItem.ToString();

            if (admin.UpdateUserInfo(userInfo[0], contact_num, email, password, level))
            {
                MessageBox.Show("User information updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update user information.");
            }

            // admin.UpdateUserInfo(user_id, email, contact_num, password, level);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            lblNameDetails.Text = userInfo[1];
            lblICDetails.Text = userInfo[2];
            lblUIDDetails.Text = userInfo[0];
            lblRoleDetails.Text = userInfo[6];
            txtContact.Text = userInfo[4];
            txtPass.Text = userInfo[5];
            txtEmail.Text = userInfo[3];
            cbLevel.SelectedItem = userInfo[7];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
