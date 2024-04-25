using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm_login_Id = new Login();
            this.Hide();
            frm_login_Id.ShowDialog();
            Close();
        }
    }
}
