using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Group8
{
    public class Manager
    {
        private SqlConnection connection;
        private string connectionString;

        public Manager()
        {
            connection = new SqlConnection();
            connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        //Add Competition
        public void Competition_Add(string CompetitionTitle, string date, string time, string PIC, string cn, string location)
        {
            connection.Open();

            string query = "INSERT INTO competitions (title, date, time, location, pic, contact_num) VALUES (@title, @date, @time, @loc, @pic, @cn)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", CompetitionTitle);
            DateTime formatted_date = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@date", formatted_date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@loc", location);
            cmd.Parameters.AddWithValue("@pic", PIC);
            cmd.Parameters.AddWithValue("@cn", cn);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Competition has been added successfully.");

            }
            else
            {
                MessageBox.Show("Failed to add Competition.");
            }

        }

        //Edit Competition
        public void Competition_Edit(string CompetitionTitle, string date, string time, string PIC, string cn, string location)
        {

            connection.Open();

            string query = "UPDATE competitions SET date = @date, time = @time, location = @loc, pic = @pic, contact_num = @cn WHERE title = @title";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", CompetitionTitle);
            DateTime formatted_date = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@date", formatted_date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@loc", location);
            cmd.Parameters.AddWithValue("@pic", PIC);
            cmd.Parameters.AddWithValue("@cn", cn);

            int rowaffected = cmd.ExecuteNonQuery();

            if (rowaffected > 0)
            {
                MessageBox.Show("Competition has been updated successfully.");

            }
            else
            {
                MessageBox.Show("Failed to update Competition.");
            }
            connection.Close();
        }

        //Delete Competition
        public void Competition_Delete(string CompetitionTitle, string date, string time, string PIC, string cn, string location)
        {
            connection.Open();

            string query = "DELETE from competitions WHERE title = @title";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", CompetitionTitle);

            int rowaffected = cmd.ExecuteNonQuery();

            if (rowaffected > 0)
            {
                MessageBox.Show("Competition has been deleted successfully.");

            }
            else
            {
                MessageBox.Show("Failed to delete Competition.");
            }

            connection.Close();

        }

        //Update Competition Result
        public void Update_Result(string CompetitionTitle, string date, string time, string PIC, string cn, string result)
        {
            connection.Open();

            string query = "UPDATE competitions SET title = @title, results = '/win/' WHERE date = @date AND time = @time AND pic = @pic AND contact_num = @contact_num";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", CompetitionTitle);
            DateTime formatted_date = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@date", formatted_date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@pic", PIC);
            cmd.Parameters.AddWithValue("@contact_num", cn);

            int row = cmd.ExecuteNonQuery();
            connection.Close();

            if (row > 0)
            {
                MessageBox.Show("Competition result has been updated successfully.");

            }
            else
            {
                MessageBox.Show("Failed to update Competition Result.");
            }
        }

        //Assign Student to Specific Competition
        public void Assign_student(string name, string game, string performance_score, string CompetitionTitle, string date, string time, string location, string PIC, string cn)
        {
            connection.Open();

            string query = "INSERT INTO competitions (name, title, date, time, location, PIC, contact_num) VALUES (@name, @title, @date, @time, @loc, @pic, @contact_num)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@title", CompetitionTitle);
            DateTime formatted_date = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@date", formatted_date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@loc", location);
            cmd.Parameters.AddWithValue("@pic", PIC);
            cmd.Parameters.AddWithValue("@contact_num", cn);

            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Student has been assigned successfully.");

            }
            else
            {
                MessageBox.Show("Failed to assigned Student.");
            }

        }

        public bool Update_Manager_Profile(string email, string newEmail, string newContactNum, string newPassword)
        {
                bool success = false;
                string query = "UPDATE user_info SET email = @newemail, contact_num = @newcontact, password = @newpassword WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@newemail", newEmail);
                cmd.Parameters.AddWithValue("@newcontact", newContactNum);
                cmd.Parameters.AddWithValue("@newpassword", newPassword);
                cmd.Parameters.AddWithValue("@email", email);
               
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
