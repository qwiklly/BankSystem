using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Convertation : Form
    {
        
        
        private int id;
        DataBase database = new DataBase();
        public Convertation(int userId)
        {
            InitializeComponent();
            async void initialize()
            {
                
                database.CheackMoney(label5, userId);
                database.CheackMoney_HKD(label29, userId);
                await database.ApiValute(label6);
                
            }
            initialize();
            this.id = userId;
        }
        
        private void Get_HKD(int dollarsHKD, int id) 
        {
            string querystring = $"UPDATE users SET user_HKD = user_HKD + {dollarsHKD} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();


            database.CloseConnection();

        }
        private void takeoff_HKD(int dollarsHKD, int id)
        {
            string querystring = $"UPDATE users SET user_HKD = user_HKD - {dollarsHKD} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();


            database.CloseConnection();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Money_takeoff mt = new Money_takeoff(id);
            try
            {
                double roubles_Convert = Double.Parse(label6.Text) * Double.Parse(dollars.Text);
                 
                if (roubles_Convert < Int32.Parse(label5.Text) )
                {
                    int dollarsHKD = Int32.Parse(dollars.Text);



                    Get_HKD(dollarsHKD, id);


                    mt.money_takeoff((int)roubles_Convert, id);

                    if (dollarsHKD == 1)
                    {
                        MessageBox.Show($"Сумма обмена при введенном {dollars.Text} долларе Гонконга составляет {roubles_Convert} рублей.");
                    }
                    else
                    {
                        MessageBox.Show($"Сумма обмена при введенных {dollars.Text} долларах Гонконга составляет {roubles_Convert} рублей.");
                    }
                    MessageBox.Show("Вы перевели валюту", "Успешно!");
                    Functional_window fw = new Functional_window(id);
                    this.Hide();
                    fw.ShowDialog();
                    Close();
                }
                else { MessageBox.Show("Недостаточно средств (RUB)", "Успешно!"); }
            }
            catch { MessageBox.Show("проверьте правильность ввода", "Успешно!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double res = Double.Parse(label6.Text) * Double.Parse(dollars.Text);
                label8.Text = res.ToString();
            }
            catch { MessageBox.Show("Введите правильное колличество долларов", "Успешно!"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Money_Get mg = new Money_Get(id);
            try
            {

                double roubles_Convert = Double.Parse(label6.Text) * Double.Parse(dollar2.Text);
                
                int dollarsHKD = Int32.Parse(dollar2.Text);
                if (dollarsHKD < Int32.Parse(label29.Text)) {


                    takeoff_HKD(dollarsHKD, id);


                    mg.money_Get((int)roubles_Convert, id);
                    if (dollarsHKD == 1)
                    {
                        MessageBox.Show($"Вы получите при введенном {dollars.Text} долларе Гонконга  {roubles_Convert} рублей.");
                    }
                    else
                    {
                        MessageBox.Show($"Вы получите при введенных {dollar2.Text} долларах Гонконга {roubles_Convert} рублей.");
                    }


                    MessageBox.Show("Вы перевели валюту", "Успешно!");
                    Functional_window fw = new Functional_window(id);
                    this.Hide();
                    fw.ShowDialog();
                    Close();
                }
                else { MessageBox.Show("Недостаточно средств (HKD)", "Успешно!"); }
            }
            catch { MessageBox.Show("Введите правильное колличество долларов", "Успешно!"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double res = Double.Parse(label6.Text) * Double.Parse(dollar2.Text);
                label10.Text = res.ToString();
            }
            catch { MessageBox.Show("Введите правильное колличество долларов", "Успешно!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Functional_window fw = new Functional_window(id);
            this.Hide();
            fw.ShowDialog();
            Close();
        }
    }
}
