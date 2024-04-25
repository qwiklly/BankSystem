using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Money_Get : Form
    {

        private int id;

        DataBase database = new DataBase();

        public Money_Get(int userId)
        {

            InitializeComponent();
            database.CheackMoney(label5, userId);
            
            this.id = userId;

        }

        public void money_Get(int SumRub, int id)
        {
            string querystring = $"UPDATE users SET user_RUB = user_RUB + {SumRub} WHERE id_user = {id}";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.OpenConnection();
            command.ExecuteNonQuery();

            
            database.CloseConnection();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub > 0)
                {


                    money_Get(SumRub, id);

                    MessageBox.Show("Вы успешно пополнили счет", "Успешно!");   
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
        

        private void Money_Get_Load(object sender, EventArgs e)
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
