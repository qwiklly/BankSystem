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

        public void CheackMoney(Label labelUserMoney, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select user_RUB from users ";

            SqlCommand command = new SqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["user_RUB"].ToString();


        }
        public void CheackMoney_HKD(Label labelUserMoney, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select user_HKD from users ";

            SqlCommand command = new SqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["user_HKD"].ToString();


        }
        public void CheackMoney_credit(Label labelUserMoney, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select credit from users ";

            SqlCommand command = new SqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["credit"].ToString();


        }
        public void CheackMoney_deposit(Label labelUserMoney, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select deposit from users ";

            SqlCommand command = new SqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["deposit"].ToString();


        }
        public async Task ApiValute(Label value_dollar) //Api valute
        {
            await Task.Run(() =>
            {
                WebClient client = new WebClient();
                var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string dollar = el.Where(x => x.Attribute("ID").Value == "R01200").Select(x => x.Element("Value").Value).FirstOrDefault();
                value_dollar.Text = dollar;

            });

        }


    }
}