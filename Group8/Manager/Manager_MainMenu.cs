
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
    public partial class Manager_MainMenu : Form
    {

        private string userEmail;
        private string userPw;

        public Manager_MainMenu(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }



        private void btnRecom_Click(object sender, EventArgs e)
        {
            Manager_StuList_Recom New_Student_Recommendation = new Manager_StuList_Recom(manager, userEmail, userPw);
            New_Student_Recommendation.Show();
            this.Hide();


        }
        Manager manager = new Manager();
        private void btnComp_Click(object sender, EventArgs e)
        {
            Manager_ViewCompSchedule New_Comp_Sch = new Manager_ViewCompSchedule(manager, userEmail, userPw);
            New_Comp_Sch.Show();
            this.Hide();

        }
        private void btnAss_Click_1(object sender, EventArgs e)
        {
            Manager_AssignStudent New_Assign = new Manager_AssignStudent(manager, userEmail, userPw);
            New_Assign.Show();
            this.Hide();


        }

        private void btnStuL_Click_1(object sender, EventArgs e)
        {
            Manager_StudList_Comp New_Student_for_Specific_Competition = new Manager_StudList_Comp(userEmail, userPw);
            New_Student_for_Specific_Competition.Show();
            this.Hide();

        }


        private void btnCompRes_Click_1(object sender, EventArgs e)
        {
            Manager_CompResult New_Competition_Result = new Manager_CompResult(manager, userEmail, userPw);
            New_Competition_Result.Show();
            this.Hide();

        }

        private void btnUpPro_Click_1(object sender, EventArgs e)
        {
            
            Manager_UpdateProfile New_Update_Profile = new Manager_UpdateProfile(userEmail, userPw);
            New_Update_Profile.Show();
            this.Hide();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
