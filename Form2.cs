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
    public partial class Form2 : Form
    {
        public Form2(int userId)
        {
            InitializeComponent();
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01200").Select(x => x.Element("Value").Value).FirstOrDefault();
            
            MessageBox.Show($" Гонконгский Доллар: {dollar}");
            label5.Text = primdb.usersArray[userId].ToString();
            label6.Text = dollar + "рублей";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
