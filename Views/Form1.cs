using System;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {
		readonly DataBase database = new DataBase();
		public Form1()
        {
            InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            fgdgdfg.Parent = pictureBox1;
			fgdgdfg.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

		}

        private void Button2_Click(object sender, EventArgs e)
        {
			try
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
				else MessageBox.Show("Что-то пошло не так! Проверьте правильность введенного ID.");
			}
			catch { MessageBox.Show("Что-то пошло не так! Проверьте правильность введенного ID."); }
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
