using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp4.Models
{
    internal class APIs : IApi
    {
        public async Task ApiValute(Label value_dollar) //Api valute
        {
            await Task.Run(() =>
            {
                WebClient client = new WebClient();
                var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string dollar = el.Where(x => x.Attribute("ID").Value == "R01200").Select(x => x.Element("Value").Value).FirstOrDefault();
                value_dollar.Text = dollar;

            });

        }
    }
}
