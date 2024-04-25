using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    internal class DataBase : IDatabase
    {
        readonly SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-05LAS6Q;Initial Catalog=test;Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        public void Dbrequest(string querystring)
        {
            SqlCommand command = new SqlCommand(querystring, GetConnection());
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }


    }
}