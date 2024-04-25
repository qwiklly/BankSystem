using System.Data.SqlClient;

internal interface IDatabase
{
    void OpenConnection();
    void CloseConnection();
    SqlConnection GetConnection();

}