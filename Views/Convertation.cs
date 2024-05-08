using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Controllers;

namespace WindowsFormsApp4
{
    public partial class Convertation : Form
    {

        readonly APIs api = new APIs();
        readonly private int id;
        readonly DataBase database = new DataBase();
        readonly Money_operations money = new Money_operations();
		public Convertation(int userId)
		{
			InitializeComponent();
			InitializeAsync(userId); // Дожидаемся завершения выполнения асинхронной операции
			this.id = userId;
		}

		private async void InitializeAsync(int userId)
		{
			async Task initialize()
			{
				money.CheackMoney(label5, userId);
				money.CheackMoney_HKD(label29, userId);
				await api.ApiValute(label6);
			}
			await initialize();
		}

		private void Get_HKD(int dollarsHKD, int id) 
        {
            database.Dbrequest($"UPDATE users SET user_HKD = user_HKD + {dollarsHKD} WHERE id_user = {id}");

        }
        private void Takeoff_HKD(int dollarsHKD, int id)
        {
            database.Dbrequest($"UPDATE users SET user_HKD = user_HKD - {dollarsHKD} WHERE id_user = {id}");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Maximized;
		}
        //Обмен рублей на гонконгские доллары
        private void Continue_Get_Click(object sender, EventArgs e)
        {

            Money_takeoff mt = new Money_takeoff(id);
            try
            {
                double roubles_Convert = Double.Parse(label6.Text) * Double.Parse(dollars.Text);
                 
                if (roubles_Convert < Int32.Parse(label5.Text) )
                {
                    int dollarsHKD = Int32.Parse(dollars.Text);



                    Get_HKD(dollarsHKD, id);


                    mt.Money_Takeoff((int)roubles_Convert, id);

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
        //Подсчет количества средств в рублях, за покупку н-ного количево долларов
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double res = Double.Parse(label6.Text) * Double.Parse(dollars.Text);
                label8.Text = res.ToString();
            }
            catch { MessageBox.Show("Введите правильное колличество долларов", "Успешно!"); }
        }
        //Обмен гонконгских долларов на рубли
        private void Button5_Click(object sender, EventArgs e)
        {
            Money_Get mg = new Money_Get(id);
            try
            {

                double roubles_Convert = Double.Parse(label6.Text) * Double.Parse(dollar2.Text);
                
                int dollarsHKD = Int32.Parse(dollar2.Text);
                if (dollarsHKD <= Int32.Parse(label29.Text)) {


                    Takeoff_HKD(dollarsHKD, id);


                    mg.Money_get((int)roubles_Convert, id);
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
        //Подсчет количества средств в рублях, за  нное количево долларов
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double res = Double.Parse(label6.Text) * Double.Parse(dollar2.Text);
                label10.Text = res.ToString();
            }
            catch { MessageBox.Show("Введите правильное колличество долларов", "Успешно!"); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Functional_window fw = new Functional_window(id);
            this.Hide();
            fw.ShowDialog();
            Close();
        }
    }
}
