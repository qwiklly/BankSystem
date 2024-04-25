using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Credit : Form
    {
        private int id;
        int percent = 4;
        private DateTime CreditStartTime;

        DataBase database = new DataBase();

        public Credit(int userId)
        {

            InitializeComponent();
            database.CheackMoney(label5, userId);
            label6.Text = percent + " %";
            database.CheackMoney_credit(label8, userId);
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

                        double currentSum = Math.Abs(startingSum) * (1 + (percent / 100.0) * (DateTime.Now - CreditStartTime).TotalHours);
                        money_GetCredit((int)currentSum, id);

                        Thread.Sleep(60000); // Update every minute

                }
            });
        }
        private void Credit_Load(object sender, EventArgs e)
        {

        }
        public void money_GetCredit(int SumRub, int id)
        {
            string querystring = $"UPDATE users SET credit = credit - {SumRub} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();


            database.CloseConnection();

        }
        public void money_takeoff_credit(int SumRub, int id)
        {
            string querystring = $"UPDATE users SET credit = credit + {SumRub} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();


            database.CloseConnection();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Functional_window newFunctionalWindow = new Functional_window(id);
            this.Hide();
            newFunctionalWindow.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Money_Get mg = new Money_Get(id);
            try
            {
                int SumRub = Int32.Parse(textBox1?.Text);
                int SumCredit = Convert.ToInt32(SumRub * 1 + percent/100);

                if (SumRub > 0)
                {


                    mg.money_Get(SumRub, id);
                    
                    money_GetCredit(SumCredit, id);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Money_takeoff takeoff = new Money_takeoff(id);
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub < Int32.Parse(label5.Text) && SumRub >0)
                {
                    takeoff.money_takeoff(SumRub, id);
                    money_takeoff_credit(SumRub, id);
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
