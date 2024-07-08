using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; // import it to your code to help you communicate to a database

namespace Tournament_Scoring_System
{
    class Database
    {
        private string ConnectionString; // Variable address
        private SqlConnection Connection; // contain a conection to communicate
        public Database() // that is a method runs when you intialise class
        {
            ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = N:\Tournament Scoring System\Tournament Scoring System\Database.mdf;Integrated Security=True";
            Connection = new SqlConnection(ConnectionString);
        }

        public void AddParticipant(string FirstName, string LastName, string IndividualTeam)
        {
            int modified;
            SqlCommand cmd = new SqlCommand("INSERT INTO [Participants] ([FirstName],[LastName],[IndividualTeam]) output INSERTED.Id VALUES(@FirstName, @LastName, @IndividualTeam)", Connection);

            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@IndividualTeam", IndividualTeam);

            Connection.Open();
            modified = (int)cmd.ExecuteScalar();
            Connection.Close();
        }

        public void UpdateParticipant(string FirstName, string LastName, string Team, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [Participants] SET [FirstName] = '" + FirstName + "', [LastName] = '" + LastName + "', [IndividualTeam] = '" + Team + "' WHERE [Id] = " + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void DeleteParticipant(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Participants] WHERE [Id]=" + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public DataTable Get_Participant()
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Participants]";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }

        public void Get_Event(string eventName, string category, string state)
        {
            int modified;
            SqlCommand cmd = new SqlCommand("INSERT INTO [Event] ([EventName],[EventCategory],[Individual]) output INSERTED.Id VALUES(@EventName, @EventCategory, @Individual)", Connection);

            cmd.Parameters.AddWithValue("@EventName", eventName);
            cmd.Parameters.AddWithValue("@EventCategory", category);
            cmd.Parameters.AddWithValue("@Individual", state);
            Connection.Open();
            modified = (int)cmd.ExecuteScalar();
            Connection.Close();
        }

        public void UpdateEvent(string eventName, string category, string team, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [Event] SET [EventName] = '" + eventName + "', [EventCategory] = '" + category + "', [Individual] = '" + team + "' WHERE [Id] = " + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void DeleteEvent(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Event] WHERE [Id]=" + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }
        public DataTable SelectEvents()
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Event]";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }

        public void AddTeam(string team)
        {
            int modified;
            SqlCommand cmd = new SqlCommand("INSERT INTO [Teams] ([TeamName]) output INSERTED.Id VALUES(@TeamName)", Connection);

            cmd.Parameters.AddWithValue("@TeamName", team);

            Connection.Open();
            modified = (int)cmd.ExecuteScalar();
            Connection.Close();
        }
        public void UpdateTeam(string teamName, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [Teams] SET [TeamName] = '" + teamName + "' WHERE [ID] = " + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }

        public void DeleteTeam(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Teams] WHERE [Id]=" + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }
        public DataTable SelectTeam()
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Teams]";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }

        public void Get_Result(int MemberID, int EventID, int Position)
        {
            int modified;
            SqlCommand cmd = new SqlCommand("INSERT INTO [Result] ([MemberID],[EventID],[Position]) output INSERTED.Id VALUES(@ParticipantID, @EventID, @Position)", Connection);

            cmd.Parameters.AddWithValue("@ParticipantID", MemberID);
            cmd.Parameters.AddWithValue("@EventID", EventID);
            cmd.Parameters.AddWithValue("@Position", Position);

            Connection.Open();
            modified = (int)cmd.ExecuteScalar();
            Connection.Close();
        }
        public void UpdateResult(int participantID, int eventID, int rank, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [Result] SET [MemberID] = " + participantID + ",[EventID] = " + eventID + ", [Position] =" + rank + " WHERE [Id] = " + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }


        public void DeleteResult(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [Result] WHERE [Id]=" + id, Connection);
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();

        }
        public DataTable SelectResult()
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Result] INNER JOIN [Participants] ON [Result].MemberID = [Participants].Id INNER JOIN [Event] ON [Result].EventID = [Event].Id";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }

        public DataTable SelectResultByTeam(string team)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Result] INNER JOIN [Participants] ON [Result].MemberID = [Participants].Id INNER JOIN [Event] ON [Result].EventID = [Event].Id WHERE [Participants].IndividualTeam = '" + team + "'";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }

        public DataTable SelectResultByIndividual(int participantID)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Result] INNER JOIN [Participants] ON [Result].MemberID = [Participants].Id INNER JOIN [Event] ON [Result].EventID = [Event].Id WHERE [Participants].Id = " + participantID;

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }

        public DataTable SelectParticipantByIndividual()
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Participants] WHERE IndividualTeam = 'Individual'";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;

        }

        public DataTable SelectPArticipantByTeam(string team)
        {
            DataTable dt = new DataTable();
            Connection.Open();
            string query = "SELECT * FROM [Participants] WHERE IndividualTeam = '" + team + "'";

            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Connection.Close();
            da.Dispose();
            return dt;
        }
    }
}