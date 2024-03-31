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

namespace Group8
{
    public partial class AddUser : Form
    {
        private admin_info admin;
        private User_Management managementForm;
        private string userEmail;
        private string userPw;

        public AddUser(string email, string password)
        {
            InitializeComponent();
            admin = new admin_info();
            this.managementForm = managementForm;
            userEmail = email;
            userPw = password;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string ic = txtIC.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string userID = txtUID.Text;
            string password = txtPass.Text;
            string role = cbRole.SelectedItem.ToString();
            string level = cbLevel.SelectedItem.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ic) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password) || cbRole.SelectedIndex == -1 || cbLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            admin_info admin = new admin_info();

            bool success = admin.add_new(name, ic, contact, email, userID, password, role, level);

            if (success)
            {
                MessageBox.Show("User added successfully!");
            }
            else
            {
                return;
                //MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            /*
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ic) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password) || cbRole.SelectedIndex == -1 || cbLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            else
            {
                admin.add_new(name, ic, contact, email, userID, password, role, level);
                MessageBox.Show("User added successfully!");
            }
            */

            /*if(success)
            {
                MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            /*
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ic) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty (email) || string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(password) || cbRole.SelectedIndex == -1 || cbLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }
            else
            {
                admin.add_new_user(name, ic, contact, email, userID, password, role, level);
                MessageBox.Show("User added successfully!");
            }

            try
            {
                admin_info admin = new admin_info();
                admin.add_new_user (name, ic, contact, email, userID, password, role, level);
                MessageBox.Show("User added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(userEmail, userPw);
            adminMenu.Show();
            this.Close();
        }
    }
}
