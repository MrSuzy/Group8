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
    public partial class frmEditSchedule : Form
    {
        private string userEmail;
        private string userPw;
        public frmEditSchedule(string email, string password)
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
                lblOldTime.Text = sessions[0]["time"].ToString();
                lblOldGame.Text = sessions[0]["game"].ToString();
                lblOldVenue.Text = sessions[0]["venue"].ToString();              
            }
            else
            {
                MessageBox.Show("No such training session found.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime date = datetimeSession.Value.Date; 
            string oldGame = lblOldGame.Text;
            string oldTime = lblOldTime.Text;  
            string oldVenue = lblOldVenue.Text;
            string newGame = cbGame.SelectedItem?.ToString();
            string newTime = cbTime.SelectedItem?.ToString();   
            string newVenue = cbVenue.SelectedItem?.ToString();

            if (newGame != null && newTime != null && newVenue != null)
            {
                Coach coach = new Coach();
                coach.Schedule_Edit(date, oldGame, oldTime, oldVenue, newGame, newTime, newVenue);
            }
            else
            {
                return;
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            datetimeSession.Value = DateTime.Now;

            cbSearchGame.SelectedIndex = -1;
            lblOldGame.Text = string.Empty;
            lblOldTime.Text = string.Empty;
            lblOldVenue.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachSchedule coachSchedule = new frmCoachSchedule(userEmail, userPw);
            coachSchedule.Show();
            this.Close();
        }

        private void frmEditSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}

