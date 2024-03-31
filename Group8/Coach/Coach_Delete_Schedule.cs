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
    public partial class frmScheduleDelete : Form
    {
        private string userEmail;
        private string userPw;
        public frmScheduleDelete(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchGame.SelectedItem == null)
            {
                MessageBox.Show("Please select a game.");
                return;
            }
            
            DateTime date = datetimeSession.Value.Date;
            string game = cbSearchGame.SelectedItem.ToString();

            Coach coach = new Coach();
            List<Dictionary<string, object>> sessions = coach.Schedule_Search(date, game);

            if (sessions.Count > 0)
            {
                lblTimeInfo.Text = sessions[0]["time"].ToString();
                lblGameInfo.Text = sessions[0]["game"].ToString();
                lblVenueInfo.Text = sessions[0]["venue"].ToString();
            }
            else
            {
                MessageBox.Show("No such training session found.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DateTime date = datetimeSession.Value.Date;
            string game = cbSearchGame.SelectedItem.ToString();

            Coach coach = new Coach();
            bool success = coach.Schedule_Delete(date, game);

            if (success) 
            {
                MessageBox.Show("Delete schedule successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete schedule.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            datetimeSession.Value = DateTime.Now;
            cbSearchGame.SelectedIndex = -1;
            lblTimeInfo.Text = string.Empty;    
            lblGameInfo.Text = string.Empty;    
            lblVenueInfo.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachSchedule coachSchedule = new frmCoachSchedule(userEmail, userPw);
            coachSchedule.Show();
            this.Close();
        }

        private void frmScheduleDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
