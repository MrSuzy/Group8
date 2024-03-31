using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Web;
using System.Xml.Linq;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.CodeDom;
using static Group8.admin_info;
using System.Drawing;
using System.Data.SqlTypes;

namespace Group8
{
    public class admin_info
    {
        private SqlConnection connection;
        private string connectionString;

        public admin_info()
        {
            connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public List<string> View_Members()
        {
            List<string> members = new List<string>();
            string query = "SELECT * FROM user_info";
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string MemberInfo = $"{reader["user_id"]} | {reader["name"]} | {reader["ic"]} | {reader["email"]} | {reader["contact_num"]} | {reader["password"]} | {reader["role"]} | {reader["level"]}";
                members.Add(MemberInfo);
            }

            connection.Close();
            return members;
        }

        public bool DeleteUserRow(string user_id)
        {
            bool success = false;

            DialogResult result  = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo);
            {
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM user_info WHERE user_id = @user_id";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                }
            }

            return success;
        }

        public bool add_new(string name, string ic, string contact, string email, string userID, string password, string role, string level)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO user_info(name, ic, contact_num, email, user_id, password, role, level) VALUES (@name, @ic, @contact_num, @email, @user_id, @password, @role, @level)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@ic", ic);
                        cmd.Parameters.AddWithValue("@contact_num", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@user_id", userID);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@level", level);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding new user: " + ex.Message);
                return false;
            }
        }

        public bool UpdateUserInfo(string user_id, string contact, string email, string password, string level)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE user_info SET contact_num = @contact_num, email = @email, password = @password, level = @level WHERE user_id = @user_id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@contact_num", contact);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@level", level);
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user information: " + ex.Message);
                return false;
            }
        }

        // competition summary 
        public DataTable Search_Competition_By_Name(string name)
        {
            DataTable dt = new DataTable();
            string query = "SELECT group_name, title, results FROM competitions WHERE name = @name";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public int GetTotalWins(string name)
        {
            int totalWins = 0;
            string query = "SELECT COUNT(*) FROM competitions WHERE name = @name AND results = 'Win'";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                connection.Open();
                totalWins = (int)cmd.ExecuteScalar();
                connection.Close();
            }
            return totalWins;
        }

        public int GetTotalLosses(string name)
        {
            int totalLosses = 0;
            string query = "SELECT COUNT(*) FROM competitions WHERE name = @name AND results = 'Loss'";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", name);
                connection.Open();
                totalLosses = (int)cmd.ExecuteScalar();
                connection.Close();
            }
            return totalLosses;
        }

        // get feedback 
        public DataTable GetFeedbacks()
        {
            DataTable dt = new DataTable();
            string query = "SELECT name, feedback FROM feedbacks";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        // monthly salary v2
        public List<Dictionary<string, object>> GetMonthlySalary(string coach_id, string month)
        {
            List<Dictionary<string, object>> loadSalary = new List<Dictionary<string, object>>();

            string query = "SELECT num_members, total_fees, club_fee, salary FROM monthly_salary WHERE coach_id = @c AND month = @m";
            SqlCommand command = new SqlCommand(@query, connection);
            command.Parameters.AddWithValue("@c", coach_id);
            command.Parameters.AddWithValue("@m", month);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> load_Salary = new Dictionary<string, object>();

                string num_members = reader["num_members"].ToString();
                load_Salary.Add("num_members", num_members);

                SqlMoney total_fees = reader.GetSqlMoney(reader.GetOrdinal("total_fees"));
                string total_fees_String = total_fees.ToString();
                load_Salary.Add("total_fees", total_fees_String);

                SqlMoney club_fee = reader.GetSqlMoney(reader.GetOrdinal("club_fee"));
                string club_fee_String = club_fee.ToString();
                load_Salary.Add("club_fee", club_fee_String);

                SqlMoney salary = reader.GetSqlMoney(reader.GetOrdinal("salary"));
                string salary_String = salary.ToString();
                load_Salary.Add("salary", salary_String);

                loadSalary.Add(load_Salary);
            }

            reader.Close();
            connection.Close();

            return loadSalary;
        }

        public bool Profile_Update(string email, string newEmail, string newContactNo, string newPassword)
        {
            bool success = false;
            string query = "UPDATE user_info SET email = @ne, contact_num = @nc, password = @np WHERE email = @e";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ne", newEmail);
            cmd.Parameters.AddWithValue("@nc", newContactNo);
            cmd.Parameters.AddWithValue("@np", newPassword);
            cmd.Parameters.AddWithValue("@e", email);


            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            if (rowsAffected > 0)
            {
                success = true;
            }
            return success;

        }
    }
}