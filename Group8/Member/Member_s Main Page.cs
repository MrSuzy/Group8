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
    public partial class Form1 : Form
    {
        private string userEmail;
        private string userPw;
        public Form1(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            EnrollAndPayment enrollmentAndPayment = new EnrollAndPayment(userEmail, userPw);
            enrollmentAndPayment.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            Unenroll unenroll = new Unenroll(userEmail, userPw);
            unenroll.Show();
            this.Hide();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Training_Schedule training_schedule = new Training_Schedule(userEmail, userPw);
            training_schedule.Show();
            this.Hide();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            Performance_Record performance_record = new Performance_Record(userEmail, userPw);
            performance_record.Show();
            this.Hide();
        }

        private void btnCompetitions_Click(object sender, EventArgs e)
        {
            All_Competition all_Competition = new All_Competition(userEmail, userPw);
            all_Competition.Show();
            this.Hide();
        }

        private void btnSuggestion_Click(object sender, EventArgs e)
        {

            Suggestion_to_Admin suggestion_To_Admin = new Suggestion_to_Admin(userEmail, userPw);
            suggestion_To_Admin.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Profile update_Profile = new Update_Profile();
            update_Profile.Show();
            this.Hide();
        }
    }
}
