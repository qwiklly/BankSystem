using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4
{
    public partial class Money_Get : Form
    {

        readonly int id;

        readonly DataBase database = new DataBase();
        readonly Money_operations money = new Money_operations();
        public Money_Get(int userId)
        {

            InitializeComponent();
            money.CheackMoney(label5, userId);
            
            this.id = userId;

        }

        public void Money_get(int SumRub, int id)
        {
            database.Dbrequest($"UPDATE users SET user_RUB = user_RUB + {SumRub} WHERE id_user = {id}");

        }



        private void Continue_Click(object sender, EventArgs e)
        {

            try
            {
                int SumRub = Int32.Parse(textBox2?.Text);

                if (SumRub > 0)
                {


                    Money_get(SumRub, id);

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

        private void Button2_Click(object sender, EventArgs e)
        {
            Functional_window newFunctionalWindow = new Functional_window(id);
            this.Hide();
            newFunctionalWindow.ShowDialog();
            this.Close();
        }
    }

        
    
}
