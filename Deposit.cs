using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp4
{
    public partial class Deposit : Form
    {
        private int id;
        int percent = 4;
        private DateTime depositStartTime;

        DataBase database = new DataBase();

        internal Deposit(int userId, IDatabase db)
        {
            InitializeComponent();
            this.database = (DataBase)db;
            database.CheackMoney(label5, userId);
            label6.Text = percent + " %";
            database.CheackMoney_deposit(label8, userId);
            this.id = userId;
            Get_money_fromdb(Int32.Parse(label8.Text));
            this.depositStartTime = DateTime.Now; // Set the deposit start time
        }
        public async void Get_money_fromdb(int startingSum)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(60000); // Update every minute
                    double currentSum = startingSum * (1 + (percent / 100.0) * (DateTime.Now - depositStartTime).TotalHours);
                    money_GetDeposit((int)currentSum, id);

                    
                }
            });
        }
        public void money_GetDeposit(int SumRub, int id)
        {
            string querystring = $"UPDATE users SET deposit = deposit + {SumRub} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();
            database.CloseConnection();

        }
        public void money_takeoff_deposit(int SumRub, int id)
        {
            string querystring = $"UPDATE users SET deposit = deposit - {SumRub} WHERE id_user = {id}";

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


        private void button1_Click_1(object sender, EventArgs e)
        {
            Money_takeoff mt = new Money_takeoff(id);
            try
            {
                int SumRub = Int32.Parse(textBox1?.Text);
                
                if (SumRub > 0 && SumRub < Int32.Parse(label5.Text))
                {


                    mt.money_takeoff(SumRub, id);
                    money_GetDeposit(SumRub * (1 + percent / 100), id);
                    MessageBox.Show("Вы успешно взяли вклад", "Успешно!");
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

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Money_Get mg = new Money_Get(id);
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub <= Int32.Parse(label8.Text))
                {
                    mg.money_Get(SumRub, id);
                    money_takeoff_deposit(SumRub, id);  
                    MessageBox.Show("Вы сняли деньги с вклада", "Успешно!");
                    Functional_window newFunctionalWindow = new Functional_window(id);
                    this.Hide();
                    newFunctionalWindow.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Сумма снятия больше суммы вклада", "FAIL!");
                }
            }
            catch { MessageBox.Show("Что-то пошло не так! Проверьте правильность введенной суммы"); }
        }
    }

}

