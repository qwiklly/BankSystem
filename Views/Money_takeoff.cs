using System;
using System.Windows.Forms;
using WindowsFormsApp4.Controllers;

namespace WindowsFormsApp4
{
    public partial class Money_takeoff : Form
    {
        readonly int id;
        readonly DataBase database = new DataBase();
        readonly Money_operations money = new Money_operations();

        public Money_takeoff(int userId)
        {
            InitializeComponent();
            money.CheackMoney(label5, userId);
            this.id = userId;
        }

        public void Money_Takeoff(int SumRub, int id)
        {
            database.Dbrequest($"UPDATE users SET user_RUB = user_RUB - {SumRub} WHERE id_user = {id}");
        } 

        private void Money_takeoff_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub < Int32.Parse(label5.Text))
                {
                    Money_Takeoff(SumRub, id);
                    MessageBox.Show("Вы сняли деньги со своего счета", "Успешно!");
                    Functional_window newFunctionalWindow = new Functional_window(id);
                    this.Hide();
                    newFunctionalWindow.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("На вашем счету недостаточно средств ", "FAIL!");         
            }
            catch { MessageBox.Show("Что-то пошло не так! Проверьте правильность введенной суммы"); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Functional_window newFunctionalWindow = new Functional_window(id);
            this.Hide();
            newFunctionalWindow.ShowDialog();
            this.Close();
        }
    } 
}
