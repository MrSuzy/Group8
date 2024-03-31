using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8
{
    public partial class frmPlayerPerformance : Form
    {
        private string userEmail;
        private string userPw;
        public frmPlayerPerformance(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
        string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(cbGame.SelectedText) ||
        string.IsNullOrWhiteSpace(txtKD.Text) ||
        string.IsNullOrWhiteSpace(txtScore.Text) ||
        string.IsNullOrWhiteSpace(txtWin.Text) ||
        string.IsNullOrWhiteSpace(txtFirst.Text) ||
        string.IsNullOrWhiteSpace(txtClutch.Text) ||
        string.IsNullOrWhiteSpace(txtAce.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string user_id = txtID.Text;
            string name = txtName.Text;
            string game = cbGame.SelectedText;
            string kd = txtKD.Text;
            int score = int.Parse(txtScore.Text);
            int winRate = int.Parse(txtWin.Text);
            int firstBloods = int.Parse(txtFirst.Text);
            int clutches = int.Parse(txtClutch.Text);   
            int aces = int.Parse(txtAce.Text);

            Coach coach = new Coach();  
            bool success = coach.Player_Performance(user_id, name, game, kd, score, winRate, firstBloods, clutches, aces);

            if (success)
            {
                MessageBox.Show("Record perfomance sucessfully.");
                
            }
            else
            {
                MessageBox.Show("Failed to record performance.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cbGame.SelectedIndex = -1;
            txtID.Clear();
            txtKD.Clear();
            txtScore.Clear();
            txtWin.Clear();
            txtFirst.Clear();
            txtClutch.Clear();
            txtAce.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachMenu coachMenu = new frmCoachMenu(userEmail, userPw);
            coachMenu.Show();
            this.Close();        
        }
    }
}
    
