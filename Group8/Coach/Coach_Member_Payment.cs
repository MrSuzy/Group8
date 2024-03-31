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
    public partial class frmMemberPayment : Form
    {
        private string userEmail;
        private string userPw;
        public frmMemberPayment(string email, string password)
        {
            InitializeComponent();
            userEmail = email;
            userPw = password;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                if (cbMonth.SelectedItem == null)
                {
                    MessageBox.Show("Please enter a name and select a month.");
                }
                else
                {
                    MessageBox.Show("Please enter a name.");
                }
                return;
            }

            if (cbMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.");
                return;
            }
            string name = txtName.Text;
            string month = cbMonth.SelectedItem.ToString();
            Coach coach = new Coach();

            Dictionary<string, object> PaymentDetails = coach.Payment_Search(name, month);

            if (PaymentDetails.Count > 0 )
            {
                lblNameInfo.Text = PaymentDetails["name"].ToString();
                lblPaymentStatusInfo.Text = PaymentDetails["status"].ToString();
                lblPaymentInfo.Text = ((DateTime)PaymentDetails["payment_date"]).ToString("dd-MMM-yy");
                lblAmountInfo.Text = PaymentDetails["amount"].ToString();
            }
            else
            {
                MessageBox.Show("no payment details found.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            cbMonth.SelectedIndex = -1;
            lblNameInfo.Text = string.Empty;    
            lblPaymentStatusInfo.Text = string.Empty;
            lblPaymentInfo.Text = string.Empty;
            lblAmountInfo.Text = string.Empty;  
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmCoachMenu coachMenu = new frmCoachMenu(userEmail, userPw);
            coachMenu.Show();
            this.Close();
        }


    }
}
