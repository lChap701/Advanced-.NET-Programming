/* in order to use the Json classes, you must install Newtonsoft.Json
 * Open NuGet package manager, and at the PM prompt enter: Install-Package Newtonsoft.Json -Version 12.0.1
 * open References in the Solution Explorer and verify it's been added
 */

using System;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace ConsumingWebServiceExample1
{
    public partial class Quotes : Form
    {
        public Quotes()
        {
            InitializeComponent();
        }

        private void btnShowQuote_Click(object sender, EventArgs e)
        {
            //using IEX stock quote api            
            string ticker = txtSymbol.Text;
            string jsonStockData;

            //call the API
            using (var web = new WebClient())
            {
                String url = "https://api.iextrading.com/1.0/stock/" + ticker + "/open-close";              
                jsonStockData = web.DownloadString(url);
            }

  // The IEX stock data is retrieved in the following format:
  //        {"open": {"price": 154,"time": 1506605400394},"close": {"price": 153.28,"time": 1506605400394},}

            //create a dynamic json object from json string
            dynamic jsonObj = JValue.Parse(jsonStockData);

            //retrieve data by accessing json object pairs: open-->price             
            txtQuote.Text = "Opening price: " + jsonObj.open.price.ToString("c") + Environment.NewLine +
                "Closing price: " + jsonObj.close.price.ToString("c");
        }

       
    }
}
