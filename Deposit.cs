using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Models;


namespace WindowsFormsApp4
{
    public partial class Deposit : Form
    {
        readonly int id;
        readonly int percent = 4;
        readonly DateTime depositStartTime;
        readonly DataBase database = new DataBase();
        readonly Money_operations money = new Money_operations();

        internal Deposit(int userId, IDatabase db)
        {
            InitializeComponent();
            this.database = (DataBase)db;
            money.CheackMoney(label5, userId);
            label6.Text = percent + " %";
            money.CheackMoney_deposit(label8, userId);
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
                    Money_GetDeposit((int)currentSum, id);

                    
                }
            });
        }
        public void Money_GetDeposit(int SumRub, int id)
        {
            database.Dbrequest($"UPDATE users SET deposit = deposit + {SumRub} WHERE id_user = {id}");

        }
        public void Money_takeoff_deposit(int SumRub, int id)
        {
            database.Dbrequest($"UPDATE users SET deposit = deposit - {SumRub} WHERE id_user = {id}");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Functional_window newFunctionalWindow = new Functional_window(id);
            this.Hide();
            newFunctionalWindow.ShowDialog();
            this.Close();
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            Money_takeoff mt = new Money_takeoff(id);
            try
            {
                int SumRub = Int32.Parse(textBox1?.Text);
                
                if (SumRub > 0 && SumRub < Int32.Parse(label5.Text))
                {


                    mt.Money_Takeoff(SumRub, id);
                    Money_GetDeposit(SumRub * (1 + percent / 100), id);
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

        private void Button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Money_Get mg = new Money_Get(id);
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub <= Int32.Parse(label8.Text))
                {
                    mg.Money_get(SumRub, id);
                    Money_takeoff_deposit(SumRub, id);  
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

