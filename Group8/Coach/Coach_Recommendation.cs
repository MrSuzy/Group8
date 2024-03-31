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
    public partial class frmRecommendation : Form
    {
        private string userEmail;
        private string userPw;
        public frmRecommendation(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name  = txtName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name to search.");
                return;
            }

            Coach coach = new Coach();
            List<Dictionary<string, object>> performances = coach.Performance_Search(name);

            if (performances.Count == 0)
            {
                MessageBox.Show("Player not found, please try again.");
                return;
            }
            else
            {
                lblNameInfo.Text = performances[0]["name"].ToString();
                lblGameInfo.Text = performances[0]["game"].ToString();
                lblScoreInfo.Text = performances[0]["performanceScore"].ToString();
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = lblNameInfo.Text;
            string game = lblGameInfo.Text;
            int performanceScore = int.Parse(lblScoreInfo.Text);

            Coach coach = new Coach();
            bool success = coach.Player_Recommendation(name, game, performanceScore);

            if (success)
            {
                MessageBox.Show("Successfully sent to mananger.");
            }
            else
            {
                MessageBox.Show("Failed to send, please try again.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            lblNameInfo.Text = string.Empty;
            lblGameInfo.Text = string.Empty;
            lblScoreInfo.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachMenu coachMenu = new frmCoachMenu(userEmail, userPw);
            coachMenu.Show();
            this.Close();
        }
    }
}
