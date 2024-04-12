using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Money_trasfer : Form
    {
        

        public Money_trasfer(int userId)
        {
            InitializeComponent();
            primdb.usersArray = primdb.LoadUsersArray();
            /*nt[] usersArray = primdb.usersArray;*/
            label5.Text = primdb.usersArray[userId].ToString();
        }

        private void Money_trasfer_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                var id = Int32.Parse(textBox1_id.Text);
                int SumRub = Int32.Parse(textBox2?.Text);

                if (id < 10 && id >= 0 && SumRub < primdb.usersArray[id])
                {
                    primdb.usersArray[id] += SumRub;
                    primdb.UpdateUsersArray(primdb.usersArray);
                    MessageBox.Show("Вы успешно пополнили счет", "Успешно!");
                    Functional_window frm_login = new Functional_window(id);
                    this.Hide();
                    frm_login.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("что-то пошло не так!, проверьте правильность введенного id ");
                }
            }
            catch { MessageBox.Show("что-то пошло не так!, проверьте правильность введенного id "); }
        }
    }
    
}
