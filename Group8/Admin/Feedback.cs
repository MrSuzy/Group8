using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Group8
{
    public partial class Feedback : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string connectionString;
        private admin_info admin;
        private string userEmail;
        private string userPw;

        public Feedback(string email, string password)
        {
            InitializeComponent();
            admin = new admin_info();
            userEmail = email;
            userPw = password;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable feedbackData = admin.GetFeedbacks();

            listViewFeedback.Items.Clear();

            listViewFeedback.View = View.Details;
            listViewFeedback.Columns.Add("Name", 50, HorizontalAlignment.Left);
            listViewFeedback.Columns.Add("Feedback", 1000, HorizontalAlignment.Left);
            //listViewFeedback.ShowItemToolTips = true;

            foreach (DataRow row in feedbackData.Rows)
            {
                ListViewItem item = new ListViewItem(row["name"].ToString());
                // ListViewItem.ListViewSubItem subItemFeedback = new ListViewItem.ListViewSubItem(item, row["feedback"].ToString());
                // subItemFeedback.ToolTipText = row["feedback"].ToString();
                item.SubItems.Add(row["feedback"].ToString());
                listViewFeedback.Items.Add(item);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(userEmail, userPw);
            adminMenu.Show();
            this.Hide();
        }
    }
}
