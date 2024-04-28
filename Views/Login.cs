using System;
using System.Data;

using System.Data.SQLite;

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

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox1_id.Text);
            DataTable table = new DataTable();
            string querystring = $"select id_user from Users where id_user = '{id}' ";
            database.OpenConnection();

            SQLiteCommand command = new SQLiteCommand(querystring, database.GetConnection());

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(table);

            
            database.CloseConnection();


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
                MessageBox.Show("Что-то пошло не так! Проверьте правильность введенного ID.");
            }
        }
    }
}
