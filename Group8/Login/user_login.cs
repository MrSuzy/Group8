using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Group8
{
    public class user_login
    {
        private SqlConnection con;
        private string connectionString;
        public string email { get; }
        public string password { get; }

        public user_login()
        {
            connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            con = new SqlConnection(connectionString);
        }

        public string login(string em, string pw)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from user_info where email =@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", em);
            cmd.Parameters.AddWithValue("@b", pw);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from user_info where email =@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", em);
                cmd2.Parameters.AddWithValue("@b", pw);

                string userRole = cmd2.ExecuteScalar().ToString();

                switch (userRole)
                {
                    case "Admin":
                        AdminMenu adminMenu = new AdminMenu(em, pw);
                        adminMenu.Show();
                        break;

                    case "Coach":
                        frmCoachMenu coachMenu = new frmCoachMenu(em, pw);
                        coachMenu.Show();
                        break;

                    case "Club Manager":
                        Manager_MainMenu ManagerMenu = new Manager_MainMenu(em, pw);
                        ManagerMenu.Show();
                        break;

                    case "Member":
                        Form1 memberMenu = new Form1(em, pw);
                        memberMenu.Show();
                        break;
                }
            }
            else
                status = "Incorrect email/password";
            con.Close();

            return status;
        }

        public Dictionary<string, object> Search_User(string email, string password)
        {
            Dictionary<string, object> userInfo = new Dictionary<string, object>();
            string query = "SELECT name, ic, user_id, email, contact_num, password FROM user_info WHERE email = @e AND password = @p";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@p", password);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                userInfo.Add("name", reader["name"]);
                userInfo.Add("ic", reader["ic"]);
                userInfo.Add("id", reader["user_id"]);
                userInfo.Add("email", reader["email"]);
                userInfo.Add("contactNo", reader["contact_num"]);
                userInfo.Add("password", reader["password"]);
            }

            reader.Close();
            con.Close();

            return userInfo;
        }
    }    
}
