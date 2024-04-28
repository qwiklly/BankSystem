
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace WindowsFormsApp4.Models
{
    internal class Money_operations : DataBase
    {

        public void CheackMoney(Label labelUserMoney, int id)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select user_RUB from Users where id_user = {id}";

            SQLiteCommand command = new SQLiteCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            labelUserMoney.Text = table.Rows[0]["user_RUB"].ToString();
            
        }

        public void CheackMoney_HKD(Label labelUserMoney, int id)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select user_HKD from Users where id_user = {id}";

            SQLiteCommand command = new SQLiteCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            labelUserMoney.Text = table.Rows[0]["user_HKD"].ToString();
           
        }
        public void CheackMoney_credit(Label labelUserMoney, int id)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select credit from Users ";

            SQLiteCommand command = new SQLiteCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["credit"].ToString();


        }
        public void CheackMoney_deposit(Label labelUserMoney, int id)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select deposit from Users ";

            SQLiteCommand command = new SQLiteCommand(querystring, GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);



            labelUserMoney.Text = table.Rows[id]["deposit"].ToString();


        }

    }
}
