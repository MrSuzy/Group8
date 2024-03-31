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
    public partial class frmCoachSchedule : Form
    {
        private string userEmail;
        private string userPw;

        public frmCoachSchedule(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewSchedule newSchedule = new frmNewSchedule(userEmail, userPw);
            newSchedule.Show();
            this.Hide();           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditSchedule editSchedule = new frmEditSchedule(userEmail, userPw);
            editSchedule.Show();
            this.Hide();                     
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmViewSchedule viewSchedule = new frmViewSchedule(userEmail, userPw);
            viewSchedule.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachMenu coachMenu = new frmCoachMenu(userEmail, userPw);
            coachMenu.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmScheduleDelete deleteSchedule = new frmScheduleDelete(userEmail, userPw);
            deleteSchedule.Show();
            this.Hide();
        }
    }
}
