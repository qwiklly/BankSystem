using System;
using System.Windows.Forms;
using WindowsFormsApp4.Controllers;

namespace WindowsFormsApp4
{
    public partial class Money_trasfer : Form
    {
        readonly Money_operations money = new Money_operations();
        readonly int id;

        public Money_trasfer(int userId)
        {
            InitializeComponent();
            money.CheackMoney(label5, userId);
            this.id = userId;
        }

        private void Money_trasfer_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Money_takeoff mt = new Money_takeoff(id);

            try
            {
                int id1 = Int32.Parse(textBox1_id?.Text);
                Money_Get mg = new Money_Get(id1);
                int SumRub = Int32.Parse(textBox2?.Text);

                if (id1 == id) MessageBox.Show($"Вы не можете перевести средства себе {id1} ", "Неудача!");
                else if (SumRub < Int32.Parse(label5.Text))
                {
                    mg.Money_get(SumRub, id1);
                    mt.Money_Takeoff(SumRub, id);
                    MessageBox.Show($"Вы успешно перевели деньги на счет {id1} ", "Успешно!");
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
