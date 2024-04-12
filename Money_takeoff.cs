﻿using System;
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
    public partial class Money_takeoff : Form
    {
        private int id;
        public Money_takeoff(int userId)
        {
            InitializeComponent();
            primdb.usersArray = primdb.LoadUsersArray();
            /*nt[] usersArray = primdb.usersArray;*/
            label5.Text = primdb.usersArray[userId].ToString();
            this.id = userId;

        }

        

        private void Money_takeoff_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int SumRub = Int32.Parse(textBox2.Text);

                if (SumRub < primdb.usersArray[id])
                {
                    primdb.usersArray[id] -= SumRub;
                    primdb.UpdateUsersArray(primdb.usersArray);
                    MessageBox.Show("Вы сняли средства со счета", "Успешно!");
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