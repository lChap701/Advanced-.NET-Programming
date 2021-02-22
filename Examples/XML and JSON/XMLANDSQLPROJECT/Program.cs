/* this program reads rows from the customer table, then writes the data out in an XML file so that the
 * information can be displayed in a web page * 
*/
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace XMLANDLINQPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string BROWSER = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe";
            //const string BROWSER = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            const string BROWSER = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            const string XMLFILENAMEPATH = @"C:\IHCC\CSharp\XMLANDSQLPROJECT\bin\Debug\Customers.xml";
            //const string XMLFILENAMEPATH = @"http://localhost:8081/kevinapps/Customers.xml";
            const string XMLFILENAMEONLY = "Customers.xml";
            const string XSLFILENAMEONLY = "customerStyle.xsl";
            string dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;";
            string dbSource = "Data Source = Premier.accdb";  
            OleDbConnection con = new OleDbConnection();
            string sql;
            DataSet ds = new DataSet();
            DataTable dt;
            OleDbDataAdapter da;
            int rows;
            
            con.ConnectionString = dbProvider + dbSource;
            con.Open();
            sql = "SELECT * FROM Customer ORDER BY CustomerNum";
            da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, "CustomerDataset");
            con.Close();
            dt = ds.Tables[0];
            rows = dt.Rows.Count;
            //rows = 10;
            Customer[] custList = new Customer[rows];
            int i = 0;

            foreach (DataRow item in dt.Rows)
            {
                custList[i] = new Customer();
                custList[i].CNum = (string)item["CustomerNum"];
                custList[i].CName = (string)item["CustomerName"];
                custList[i].CStreet = (string)item["Street"];
                custList[i].CCity = (string)item["City"];
                custList[i].CState = (string)item["State"];
                custList[i].CZip = (string)item["Zip"];
                custList[i].CBalance = (decimal)item["Balance"];
                custList[i].CCrLimit = (decimal)item["CreditLimit"];
                custList[i].CRepNum = (string)item["RepNum"];
                i++;
            }

            //instantiate the SerializeAndDisplayInBrowser class,
            //  which basically executes the serialize and display logic
            //the class requires the array of objects to serialize, xml file name,
            //xsl file name (stylesheet), browser to use, and file to open in browser
            //constructor is overloaded to allow serialization only (create the .xml file),
            //  serialize and add the stylesheet to the xml file, or
            //  serialize, add stylesheet and launch xml file in browser            

            //serialize, add stylesheet, and launch browser
            SerializeAndDisplayInBrowser obj =
                new SerializeAndDisplayInBrowser(custList, XMLFILENAMEONLY, XSLFILENAMEONLY,
                                                 BROWSER, XMLFILENAMEPATH);
            
            //serialize and add stylesheet
            //SerializeAndDisplayInBrowser obj =
            //    new SerializeAndDisplayInBrowser(custList, XMLFILENAMEONLY, XSLFILENAMEONLY);

            //serialize only
            //SerializeAndDisplayInBrowser obj =
            //    new SerializeAndDisplayInBrowser(custList, XMLFILENAMEONLY);
            
        }

    }

    [Serializable]
    public class Customer
    {        
        public string CNum { get; set; }
        public string CName { get; set; }
        public string CStreet { get; set; }
        public string CCity { get; set; }
        public string CState { get; set; }
        public string CZip { get; set; }
        public decimal CBalance { get; set; }
        public decimal CCrLimit { get; set; }
        public string CRepNum { get; set; }
    }
}
