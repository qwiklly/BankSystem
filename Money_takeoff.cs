using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Money_takeoff : Form
    {
        private int id;

        DataBase database = new DataBase();
        public Money_takeoff(int userId)
        {
            InitializeComponent();
            database.cheackMoney(label5, userId);

            this.id = userId;

        }
        public void money_takeoff(int SumRub, int id)
        {
            
            string querystring = $"UPDATE users SET user_RUB = user_RUB - {SumRub} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();
            database.closeConnection();
        }
        

        private void Money_takeoff_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub < Int32.Parse(label5.Text))
                {
                    money_takeoff(SumRub, id);
                    MessageBox.Show("Вы сняли деньги со своего счета", "Успешно!");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
