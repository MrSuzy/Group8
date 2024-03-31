using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;

namespace Group8
{
    public class Coach
    {
        private SqlConnection connection;
        private string connectionString;


        public Coach()
        {
            connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void Schedule_Add(DateTime date, string game, string time, string level, string venue, string coach)
        {
            string query = "INSERT INTO training_schedule (date, game, time, level, venue, coach) VALUES (@d, @g, @t, @l, @v, @c)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@g", game);
            cmd.Parameters.AddWithValue("@t", time);
            cmd.Parameters.AddWithValue("@l", level);
            cmd.Parameters.AddWithValue("@v", venue);
            cmd.Parameters.AddWithValue("@c", coach);

            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();


            if (rowsAffected > 0)
            {
                MessageBox.Show("Training Session has been added successfully.");

            }
            else
            {
                MessageBox.Show("Failed to add training session.");
            }
            connection.Close();
        }


        public List<Dictionary<string, object>> Schedule_Search(DateTime date, string game)
        {
            List<Dictionary<string, object>> sessions = new List<Dictionary<string, object>>();

            string query = "SELECT * FROM training_schedule WHERE date = @d AND game = @g";
            SqlCommand cmd = new SqlCommand(@query, connection);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@g", game);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> session = new Dictionary<string, object>();
                session.Add("date", reader["date"]);
                session.Add("game", reader["game"]);
                session.Add("time", reader["time"]);
                session.Add("venue", reader["venue"]);
                sessions.Add(session);
            }

            reader.Close();
            connection.Close();

            return sessions;
        }

        public void Schedule_Edit(DateTime date, string oldGame, string oldTime, string oldVenue, string newGame, string newTime, string newVenue)
        {
            string query = "UPDATE training_schedule SET game = @ng, time = @nt, venue = @nv " +
                           "WHERE date = @d AND game = @og AND time = @ot AND venue = @ov";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ng", newGame);
            cmd.Parameters.AddWithValue("@nt", newTime);
            cmd.Parameters.AddWithValue("@nv", newVenue);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@og", oldGame);
            cmd.Parameters.AddWithValue("@ot", oldTime);
            cmd.Parameters.AddWithValue("@ov", oldVenue);


            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Training session has been edited successfully.");
            }
            else
            {
                MessageBox.Show("Failed to edit training session.");
            }
            connection.Close();
        }

        public Dictionary<string, object> Payment_Search(string name, string month)
        {
            Dictionary<string, object> PaymentDetails = new Dictionary<string, object>();
            DateTime date = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture);
            int monthNum = date.Month;
            string query = "SELECT * FROM members_payment WHERE name = @n AND MONTH(payment_date) = @m";
            SqlCommand cmd = new SqlCommand(@query, connection);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@m", monthNum);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PaymentDetails.Add("name", reader["name"]);
                PaymentDetails.Add("status", reader["status"]);
                PaymentDetails.Add("payment_date", reader["payment_date"]);
                PaymentDetails.Add("amount", reader["amount"]);
            }

            reader.Close();
            connection.Close();

            return PaymentDetails;
        }

        public List<string> Schedule_View(string monthName)
        {
            List<string> sessions = new List<string>();
            string[] formats = { "MMMM", "MMM" };
            DateTime date;
            bool parsed = DateTime.TryParseExact(monthName, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);
            if (!parsed)
                return sessions;

            int month = date.Month;
            string query = "SELECT FORMAT(date, 'dd-MMM-yy') AS date, game, time, venue FROM training_schedule WHERE MONTH(date) = @m";
            SqlCommand cmd = new SqlCommand(@query, connection);
            cmd.Parameters.AddWithValue("@m", month);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string sessionInfo = $"{reader["date"]}: {reader["game"]} - {reader["time"]} at {reader["venue"]}";
                sessions.Add(sessionInfo);
            }

            connection.Close();

            return sessions;

        }

        public bool Schedule_Delete(DateTime date, string game)
        {
            bool success = false;
            string query = "DELETE FROM training_schedule WHERE CONVERT(date, date) = @d AND game = @g";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@g", game);

            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                success = true;
            }
            connection.Close();
            return success;
        }

        public bool Player_Performance(string user_id, string name, string game, string kd, int score, int winRate, int firstBloods, int clutches, int aces)
        {
            bool success = false;
            string query = "INSERT INTO players_performance (user_id, name, game, kd, performance_score, win_rate, first_bloods, total_clutches, total_aces)" +
                           "VALUES (@id, @n, @g, @kd, @s, @w, @f, @c, @a)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", user_id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@g", game);
            cmd.Parameters.AddWithValue("@kd", kd);
            cmd.Parameters.AddWithValue("@s", score);
            cmd.Parameters.AddWithValue("@w", winRate);
            cmd.Parameters.AddWithValue("@f", firstBloods);
            cmd.Parameters.AddWithValue("@c", clutches);
            cmd.Parameters.AddWithValue("@a", aces);

            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                success = true;
            }
            connection.Close();
            return success;
        }

        public List<Dictionary<string, object>>Performance_Search(string name)
        {
            List<Dictionary<string, object>> performances = new List<Dictionary<string, object>>();
            string query = "SELECT * FROM players_performance WHERE name = @n";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@n", name);


            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Dictionary<string, object> performance = new Dictionary<string, object>();
                performance.Add("name", reader["name"]);
                performance.Add("game", reader["game"]);
                performance.Add("performanceScore", reader["performance_score"]);
                performances.Add(performance);
            }
            
            reader.Close();
            connection.Close();
            
            return performances;
        }

        public bool Player_Recommendation(string name, string game, int performanceScore)
        {
            string query = "INSERT INTO recommendation (name, game, performance_score) VALUES (@n, @g, @s)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@g", game);
            cmd.Parameters.AddWithValue("@s", performanceScore);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
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
