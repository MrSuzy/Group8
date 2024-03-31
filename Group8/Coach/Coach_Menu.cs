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

namespace Group8
{
    public partial class frmCoachMenu : Form
    {
        private string userEmail;
        private string userPw;
        
        public frmCoachMenu(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }


        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmCoachSchedule coachSchedule = new frmCoachSchedule(userEmail, userPw);
            coachSchedule.Show();
            this.Hide();
            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmMemberPayment memberPayment = new frmMemberPayment(userEmail, userPw);
            memberPayment.Show();
            this.Hide();                      
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            frmPlayerPerformance playerPerformance = new frmPlayerPerformance(userEmail, userPw);
            playerPerformance.Show();
            this.Hide();
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            frmRecommendation recommendation = new frmRecommendation(userEmail, userPw);
            recommendation.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateProfile updateProfile = new frmUpdateProfile(userEmail, userPw);
            updateProfile.Show();
            this.Hide();
        }

        private void btnLgOut_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
