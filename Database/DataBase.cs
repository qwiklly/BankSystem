using System.Data;
using System.Data.SQLite;

namespace WindowsFormsApp4
{
    internal class DataBase : IDatabase
    {
        readonly SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=MyDB.sqlite;Version=3;");

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

        public void Dbrequest(string querystring)
        {
            SQLiteCommand command = new SQLiteCommand(querystring, GetConnection());
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}


