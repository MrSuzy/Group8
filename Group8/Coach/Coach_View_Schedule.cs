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
    public partial class frmViewSchedule : Form
    {
        private string userEmail;
        private string userPw;
        public frmViewSchedule(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.");
                return;
            }
           
            Coach coach = new Coach();
            string selectedMonth = cbMonth.SelectedItem.ToString();
            lbSession.Items.Clear();
            List<string> sessions = coach.Schedule_View(selectedMonth);
            
            foreach (string session in sessions)
            {
                lbSession.Items.Add(session);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbMonth.SelectedIndex = -1;
            lbSession.Items.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachSchedule coachSchedule = new frmCoachSchedule(userEmail, userPw);
            coachSchedule.Show();
            this.Close();
        }
    }
}
