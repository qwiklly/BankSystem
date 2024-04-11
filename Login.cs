using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
        }
/*        public void BankSum()
        {

            // Парсин кура валют с сайте ЦБ РФ:
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string eur = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();

            kursval_dollar.Text = (dollar);
            kursval_euro.Text = (eur);


            decimal rub = Convert.ToDecimal(lbsum_end.Text);
            decimal doll = Convert.ToDecimal(kursval_dollar.Text);
            decimal euro = Convert.ToDecimal(kursval_euro.Text);
            lb_sum_dollar.Text = (rub * doll).ToString();
            lb_sum_euro.Text = (rub * euro).ToString();



            snm();
        }*/
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

                if (id < 10 && id >= 0)
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
