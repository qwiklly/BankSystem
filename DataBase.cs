using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-05LAS6Q;Initial Catalog=test;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
        
        public void cheackMoney(Label labelUserMoney, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select user_RUB from users ";

            SqlCommand command = new SqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            

            labelUserMoney.Text = table.Rows[id]["user_RUB"].ToString() ;
            
           
        }
        public void cheackMoney_HKD(Label labelUserMoney, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select user_HKD from users ";

            SqlCommand command = new SqlCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["user_HKD"].ToString();


        }
        public void ApiValute(Label value_dollar)
        {

            
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01200").Select(x => x.Element("Value").Value).FirstOrDefault();
            value_dollar.Text = dollar ;
        }


    }
}