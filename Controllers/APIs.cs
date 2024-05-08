using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;

namespace WindowsFormsApp4.Controllers
{
    internal class APIs : IApi
    {
        //Getting value of hong kong dollar in rub (получаем цену 1 гонконгского доллара в рублях)
        public async Task ApiValute(Label value_dollar) //Api valute
        {
			await Task.Run(() =>
			{
				try
				{
					WebClient client = new WebClient();
					var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
					XDocument xdoc = XDocument.Parse(xml);
					var el = xdoc.Element("ValCurs").Elements("Valute");
					string dollar = el.Where(x => x.Attribute("ID").Value == "R01200").Select(x => x.Element("Value").Value).FirstOrDefault();
					value_dollar.Text = dollar;
				}
				catch (Exception ex)
				{
					// Обработка ошибки
					Console.WriteLine("Ошибка при загрузке данных из API: " + ex.Message);
				}
			});
		}
    }
}
