
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp4.Models
{
    internal class Money_operations : DataBase
    {
        
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

    }
}
