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
using System.Configuration;
using System.Web;

namespace Group8
{
    public partial class frmNewSchedule : Form
    {
        private string userEmail;
        private string userPw;
        public frmNewSchedule(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = datetimeSession.Value.Date;
            string game = cbGame.SelectedItem?.ToString();
            string time = cbTime.SelectedItem?.ToString();
            string level = cbLevel.SelectedItem?.ToString();
            string venue = cbVenue.SelectedItem?.ToString();
            string coach = cbCoach.SelectedItem?.ToString();
            Coach coaches = new Coach();

            if (game != null && time != null && level != null && venue != null && coach != null)
            {
                coaches.Schedule_Add(date, game, time, level, venue, coach);
            }
            else
            {
                MessageBox.Show("Please select above details to add.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            datetimeSession.Value = DateTime.Now;

            cbTime.SelectedIndex = -1;
            cbGame.SelectedIndex = -1;
            cbLevel.SelectedIndex = -1;
            cbVenue.SelectedIndex = -1;
            cbCoach.SelectedIndex = -1;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachSchedule coachSchedule = new frmCoachSchedule(userEmail, userPw);
            coachSchedule.Show();
            this.Close();
        }
    }

}
