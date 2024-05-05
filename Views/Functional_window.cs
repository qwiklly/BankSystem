using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp4.Controllers;

namespace WindowsFormsApp4
{
    public partial class Functional_window : Form
    {
        readonly int userId;
        readonly DataBase database = new DataBase();
        readonly Money_operations money = new Money_operations();
        
        public Functional_window(int id)
        {
            InitializeComponent();
            money.CheackMoney(label24, id);
            money.CheackMoney_HKD(label29, id);
            label28.Text = id.ToString();
            this.userId = id;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {       
            this.WindowState = FormWindowState.Maximized;
        }

        //Снятие средств со счета
        private void Panel2_Click(object sender, EventArgs e)
        {
            Money_takeoff takeoff = new Money_takeoff(userId);
            this.Hide();
            takeoff.ShowDialog();
            Close();
        }
        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; // изменяем цвет панели при наведении на неё курсора
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; // возвращаем исходный цвет панели при уходе курсора с неё
        }
        //Пополнение счета
        private void Panel3_Click(object sender, EventArgs e)
        {
            Money_Get  money_Get = new Money_Get(userId);
            this.Hide();
            money_Get.ShowDialog();
        }
        private void Panel3_MouseEnter_1(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; // изменяем цвет панели при наведении на неё курсора
        }

        private void Panel3_MouseLeave_1(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; // возвращаем исходный цвет панели при уходе курсора с неё
        }
        private void Panel4_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit(userId);
            this.Hide();
            credit.ShowDialog();
        }
        private void Panel4_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue;
        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White;
        }

        private void Panel5_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(userId);
            this.Hide();
            deposit.ShowDialog();
            
        }
        private void Panel5_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue;
        }

        private void Panel5_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White;
        }
        private void Panel6_Click(object sender, EventArgs e)
        {
            Money_trasfer Money_trasfer = new Money_trasfer(userId);
            this.Hide();
            Money_trasfer.ShowDialog();
            Close();
        }
        private void Panel6_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; 
        }

        private void Panel6_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; 
        }

        private void Panel7_Click(object sender, EventArgs e)
        {
            Convertation Convertation = new Convertation(userId);
            this.Hide();
            Convertation.ShowDialog();
            Close();
        }
        private void Panel7_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.LightBlue; 
        }

        private void Panel7_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White; 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            Close();
        }

        
    }
}
