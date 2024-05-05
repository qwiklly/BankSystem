using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace WindowsFormsApp4
{
    internal class DataBase : IDatabase
    {
		static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
		readonly SQLiteConnection sqliteConnection = new SQLiteConnection(connectionString);

		public void OpenConnection()
        {
            if (sqliteConnection.State == ConnectionState.Closed)
            {
                sqliteConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqliteConnection.State == ConnectionState.Open)
            {
                sqliteConnection.Close();
            }
        }

        public SQLiteConnection GetConnection()
        {
            return sqliteConnection;
        }
        //Basic commands for bd connection (подключаемся к базе данных и создаём запросы)
        public void Dbrequest(string querystring)
        {
            SQLiteCommand command = new SQLiteCommand(querystring, GetConnection());
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}


