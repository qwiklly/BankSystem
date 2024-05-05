using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace WindowsFormsApp4.Controllers
{
    internal class Money_operations : DataBase
    {
        //Cheacking user's balance in rub (Определяем количество денег у пользователя в рублях)
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

        //Cheacking user's balance in HKD (Определяем количество денег у пользователя в Гонконгских долларах)
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

        //Cheacking user's credit (Определяем сколько рублей составляет кредит)
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

        //Cheacking user's deposit (Определяем сколько рублей составляет депозит)
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
