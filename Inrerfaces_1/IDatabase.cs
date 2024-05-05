using System.Data.SQLite;

internal interface IDatabase
{
    void OpenConnection();
    void CloseConnection();
    SQLiteConnection GetConnection();

}