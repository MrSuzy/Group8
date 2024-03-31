using System;
using System.Windows.Forms;

namespace Group8
{
    public partial class AdminMenu : Form
    {
        private string userEmail;
        private string userPw;

        public AdminMenu(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            User_Management userManage = new User_Management(userEmail, userPw);
            userManage.Show();
            this.Hide();
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            ProfileUpdate profupdate = new ProfileUpdate(userEmail, userPw);
            profupdate.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(userEmail, userPw);
            feedback.Show();
            this.Hide();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            CompetitionSummary summary = new CompetitionSummary(userEmail, userPw);
            summary.Show();
            this.Hide();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            MonthlyIncomeReport income = new MonthlyIncomeReport(userEmail, userPw);
            income.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show();
            this.Hide();
        }
    }
}
