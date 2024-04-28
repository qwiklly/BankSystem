using System;
using System.Data.SQLite;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4
{
    public partial class Credit : Form
    {
        readonly int id;
        readonly int percent = 4;
        readonly DateTime CreditStartTime;

        readonly DataBase database = new DataBase();
        readonly Money_operations money = new Money_operations();

        internal Credit(int userId, IDatabase db)
        {

            InitializeComponent();
            this.database = (DataBase)db;
            money.CheackMoney(label5, userId);
            label6.Text = percent + " %";
            money.CheackMoney_credit(label8, userId);
            Get_money_fromdb(Int32.Parse(label8.Text));
            this.CreditStartTime = DateTime.Now; // Set the deposit start time

            this.id = userId;

        }
        public async void Get_money_fromdb(int startingSum)
        {
            await Task.Run(() =>
            {
                while (Int32.Parse(label8.Text)<0)
                {
                    Thread.Sleep(30000); // Update every 30 sec
                    double currentSum = Math.Abs(startingSum) * (1 + (percent / 100.0) * (DateTime.Now - CreditStartTime).TotalHours);
                    Money_GetCredit((int)currentSum, id);

                        

                }
            });
        }
        private void Credit_Load(object sender, EventArgs e)
        {

        }
        public void Money_GetCredit(int SumRub, int id)
        {
            database.Dbrequest($"UPDATE users SET credit = credit - {SumRub} WHERE id_user = {id}");

        }
        public void Money_takeoff_credit(int SumRub, int id)
        {
            string querystring = $"UPDATE users SET credit = credit + {SumRub} WHERE id_user = {id}";

            SQLiteCommand command = new SQLiteCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();


            database.CloseConnection();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Functional_window newFunctionalWindow = new Functional_window(id);
            this.Hide();
            newFunctionalWindow.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Money_Get mg = new Money_Get(id);
            try
            {
                int SumRub = Int32.Parse(textBox1?.Text);
                int SumCredit = Convert.ToInt32(SumRub * 1 + percent/100);

                if (SumRub > 0)
                {


                    mg.Money_get(SumRub, id);
                    
                    Money_GetCredit(SumCredit, id);
                    MessageBox.Show("Вы успешно взяли крредит", "Успешно!");
                    Functional_window newFunctionalWindow = new Functional_window(id);
                    this.Hide();
                    newFunctionalWindow.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Что-то пошло не так! Проверьте правильность введенной суммы");
                }
            }
            catch { MessageBox.Show("Что-то пошло не так! Проверьте правильность введенной суммы"); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Money_takeoff takeoff = new Money_takeoff(id);
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub < Int32.Parse(label5.Text) && SumRub >0)
                {
                    takeoff.Money_Takeoff(SumRub, id);
                    Money_takeoff_credit(SumRub, id);
                    MessageBox.Show("Вы погасили кредит", "Успешно!");
                    Functional_window newFunctionalWindow = new Functional_window(id);
                    this.Hide();
                    newFunctionalWindow.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("На вашем счету недостаточно средств ", "FAIL!");
                }
            }
            catch { MessageBox.Show("Что-то пошло не так! Проверьте правильность введенной суммы"); }
        }
    }
}
