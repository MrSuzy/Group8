using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8
{
    public partial class User_Management : Form
    {
        private admin_info admin;
        private string userEmail;
        private string userPw;

        public User_Management(string email, string password)
        {
            InitializeComponent();
            admin = new admin_info();
            userEmail = email;
            userPw = password;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            admin_info admin = new admin_info();
            List<string> members = admin.View_Members();
            lbUserInfo.Items.Clear();

            foreach (string member in members)
            {
                lbUserInfo.Items.Add(member);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(userEmail, userPw);
            addUser.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbUserInfo.SelectedIndex != -1)
            {
                string selectedUser = lbUserInfo.SelectedItem.ToString();
                string[] userInfo = selectedUser.Split('|').Select(item => item.Trim()).ToArray();
                //string user_id = selectedUser.Split('|')[0].Trim();
                EditUser editUser = new EditUser(userInfo, userEmail, userPw);
                editUser.Show();
                // admin.View_Members();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbUserInfo.SelectedIndex != -1)
            {
                string selectedUser = lbUserInfo.SelectedItem.ToString();
                string user_id = selectedUser.Split('|')[0].Trim();

                bool success = admin.DeleteUserRow(user_id);
                if (success)
                {
                    MessageBox.Show("User deleted successfully.");
                    // admin.View_Members();
                    btnView_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete user. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
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
