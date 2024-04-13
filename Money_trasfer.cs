using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Money_trasfer : Form
    {
        DataBase database = new DataBase();
        

        private int id;
        

        public Money_trasfer(int userId)
        {
            InitializeComponent();
            database.cheackMoney(label5, userId);

            this.id = userId;
        }

        private void Money_trasfer_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        Money_takeoff mt = new Money_takeoff(id);
            try
            {
                int id1 = Int32.Parse(textBox1_id?.Text);
                Money_Get mg = new Money_Get(id1);

                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub < Int32.Parse(label5.Text))
                {
                    mg.money_Get(SumRub, id1);
                    mt.money_takeoff(SumRub, id);

                    MessageBox.Show($"Вы успешно перевели деньги на счет {id1} ", "Успешно!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Functional_window newFunctionalWindow = new Functional_window(id);
            this.Hide();
            newFunctionalWindow.ShowDialog();
            this.Close();
        }
    }
    
}
