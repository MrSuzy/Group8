
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
    public partial class Manager_EditCompSche : Form
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
        public Manager_EditCompSche(Manager manager, string target_comp, string comp_date, string comp_time, string comp_pic, string comp_cn, string comp_loc, string email, string password)
        {
            InitializeComponent();
            this.manager = manager;
            this.target_comp = target_comp;
            this.comp_date = comp_date;
            this.comp_time = comp_time;
            this.comp_pic = comp_pic;
            this.comp_cn = comp_cn;
            this.comp_loc = comp_loc;
            userEmail = email;
            userPw = password;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Manager_MainMenu New_MainMenu = new Manager_MainMenu(userEmail, userPw);
            New_MainMenu.ShowDialog();
            this.Hide();
        }

        private void Manager_EditCompSche_Load(object sender, EventArgs e)
        {
            
            lblinfoCompT.Text = target_comp.ToString();
            txtBoxDate.Text = comp_date.ToString();
            txtBoxTime.Text = comp_time.ToString();
            txtBoxPIC.Text = comp_pic.ToString();
            txtBoxCN.Text = comp_cn.ToString();
            txtBoxLoc.Text = comp_loc.ToString();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string comp_name = lblinfoCompT.Text;
            string comp_date = txtBoxDate.Text;
            string comp_time = txtBoxTime.Text;
            string comp_pic = txtBoxPIC.Text;
            string comp_cn = txtBoxCN.Text;
            string comp_loc = txtBoxLoc.Text;
            manager.Competition_Edit(comp_name, comp_date, comp_time, comp_pic, comp_cn, comp_loc);
            
        }

        private void lblComT_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
