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
    public partial class Convertation : Form
    {
        private string ROUBLES_PER_DOLLAR;
        public Convertation(int userId)
        {
            primdb.usersArray = primdb.LoadUsersArray();
            InitializeComponent();
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01200").Select(x => x.Element("Value").Value).FirstOrDefault();
            label5.Text = primdb.usersArray[userId].ToString();

            label6.Text = dollar + "рублей";
            this.ROUBLES_PER_DOLLAR = dollar;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double roubles = Double.Parse(ROUBLES_PER_DOLLAR) * Int32.Parse(dollars.Text);
            MessageBox.Show($"Сумма обмена при введенных {dollars.Text} долларах США составляет {roubles} рублей.");
        }
    }
}
