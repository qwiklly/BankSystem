using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        readonly DataBase database = new DataBase();

        
        public Functional_window(int id)
        {
            InitializeComponent();
            
            database.cheackMoney(label24, id);
            database.cheackMoney_HKD(label29, id);

            label28.Text = id.ToString();
            this.userId = id;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {       
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        //Снятие средств со счета
        private void panel2_Click(object sender, EventArgs e)
        {
            Money_takeoff takeoff = new Money_takeoff(userId);
            this.Hide();
            takeoff.ShowDialog();
            Close();
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; // изменяем цвет панели при наведении на неё курсора
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; // возвращаем исходный цвет панели при уходе курсора с неё
        }
        //Пополнение счета
        private void panel3_Click(object sender, EventArgs e)
        {
            Money_Get  money_Get= new Money_Get(userId);
            this.Hide();
            money_Get.ShowDialog();
            

        }
        private void panel3_MouseEnter_1(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; // изменяем цвет панели при наведении на неё курсора
        }

        private void panel3_MouseLeave_1(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; // возвращаем исходный цвет панели при уходе курсора с неё
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Money_trasfer Money_trasfer = new Money_trasfer(userId);
            this.Hide();
            Money_trasfer.ShowDialog();
            Close();
        }
        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; 
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; 
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Convertation Convertation = new Convertation(userId);
            this.Hide();
            Convertation.ShowDialog();
            Close();
        }
        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; 
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; 
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            Close();
        }



        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; 
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; 
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
