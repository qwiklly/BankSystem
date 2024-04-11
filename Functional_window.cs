using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Functional_window : Form
    {
        private int userId;









        public Functional_window(int id)
        {
            
            InitializeComponent();
            primdb.usersArray = primdb.LoadUsersArray();
            label24.Text = primdb.usersArray[id].ToString();
            label23.Text = "Id пользователя: " + id.ToString();
            this.userId = id;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Click(object sender, EventArgs e)
        {

            Money_trasfer frm_login1 = new Money_trasfer(userId);
            this.Hide();
            frm_login1.ShowDialog();
            Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(userId);
            this.Hide();
            form2.ShowDialog();
            Close();
        }
    }
}
