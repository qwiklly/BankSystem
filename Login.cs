using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;


namespace WindowsFormsApp4
{
    
    public partial class Login : Form
    {

        readonly DataBase database = new DataBase();

        public Login()
        {
            InitializeComponent();
        }
        
        

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Int32.Parse(textBox1_id.Text);
                int current_user = Int32.Parse(textBox1_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = $"select id_user from users where id_user = '{id}' ";

                SqlCommand command = new SqlCommand(querystring, database.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)

                {
                    MessageBox.Show("Вы успешно вошли", "Успешно!");
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
            catch  { MessageBox.Show("что-то пошло не так!, проверьте правильность введенного id "); }
        }
    }
}
