
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Group8
{
    public partial class Manager_AddComp : Form
    {
        private string userEmail;
        private string userPw;
        public Manager_AddComp(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }


        Manager manager;
        public Manager_AddComp(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.Show();
            this.Hide();

        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string comp_name = txtBoxComT.Text;
            string comp_date = txtBoxDate.Text;
            string comp_time = txtBoxTime.Text;
            string comp_pic = txtBoxPIC.Text;
            string comp_cn = txtBoxCN.Text;
            string comp_loc = txtBoxLoc.Text;
            manager.Competition_Add(comp_name, comp_date, comp_time, comp_pic, comp_cn, comp_loc);


        }
    }
}
