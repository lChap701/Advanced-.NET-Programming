using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExampleClasses;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace RepCustomerWithXML
{
    public partial class Form1 : Form
    {
        const string BROWSER = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
        const string XMLFILENAMEPATHREP = @"C:\IHCC\Advanced.NET\RepCustomerWithXML\RepCustomerWithXML\bin\Debug\Reps.xml";        
        const string XMLFILENAMEONLYREP = "Reps.xml";
        const string XSLFILENAMEONLYREP = "repStyle.xsl";
        const string XMLFILENAMEPATHCUST = @"C:\IHCC\Advanced.NET\RepCustomerWithXML\RepCustomerWithXML\bin\Debug\Customers.xml";
        const string XMLFILENAMEONLYCUST = "Customers.xml";
        const string XSLFILENAMEONLYCUST = "customerStyle.xsl";

        public Form1()
        {
            InitializeComponent();
        }

        private void allRepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Server = PC-KTHROCKM; Database = RepCustomer; Trusted_Connection = yes;";
                conn.Open();
                //MessageBox.Show("Database connection successful");
                string sel = "SELECT RepNum, RepName, RepSalary ";
                string from = "FROM Rep ";
                string orderby = "ORDER BY 1";
                string selCommand = sel + from + orderby;
                SqlDataAdapter da = new SqlDataAdapter(selCommand, conn);
                DataSet ds = new DataSet();
                DataTable dt;
                da.Fill(ds, "Reps");
                conn.Close();
                dt = ds.Tables[0];
                int rows = dt.Rows.Count;
                Rep[] repList = new Rep[rows];  //instantiate an array object
                int i = 0;
                foreach (DataRow item in dt.Rows)
                {
                    repList[i] = new Rep(); //instantiate a Rep and store the address in the array
                    repList[i].RNum = (string)item["RepNum"];
                    repList[i].RName = (string)item["RepName"];
                    repList[i].RSalary = (double)item["RepSalary"];                    
                    i++;
                }

                //serialize, add stylesheet, and launch browser
                SerializeAndDisplayInBrowser obj =
                    new SerializeAndDisplayInBrowser(repList, XMLFILENAMEONLYREP, XSLFILENAMEONLYREP,
                                                     BROWSER, XMLFILENAMEPATHREP);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Database error: " + exc.Message);

            }

        }

        private void repsBySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string inSalary = Interaction.InputBox("Enter a salary: ", "Search by Salary");
            double sal;

            Double.TryParse(inSalary, out sal);

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Server = PC-KTHROCKM; Database = RepCustomer; Trusted_Connection = yes;";
                conn.Open();
                //MessageBox.Show("Database connection successful");
                string sel = "SELECT RepNum, RepName, RepSalary ";
                string from = "FROM Rep ";
                string where = "WHERE RepSalary >= " + sal;
                string orderby = " ORDER BY 1";
                string selCommand = sel + from + where + orderby;
                SqlDataAdapter da = new SqlDataAdapter(selCommand, conn);
                DataSet ds = new DataSet();
                DataTable dt;
                da.Fill(ds, "Reps");
                conn.Close();
                dt = ds.Tables[0];
                int rows = dt.Rows.Count;
                Rep[] repList = new Rep[rows];  //instantiate an array object
                int i = 0;
                foreach (DataRow item in dt.Rows)
                {
                    repList[i] = new Rep(); //instantiate a Rep and store the address in the array
                    repList[i].RNum = (string)item["RepNum"];
                    repList[i].RName = (string)item["RepName"];
                    repList[i].RSalary = (double)item["RepSalary"];
                    i++;
                }

                //serialize, add stylesheet, and launch browser
                SerializeAndDisplayInBrowser obj =
                    new SerializeAndDisplayInBrowser(repList, XMLFILENAMEONLYREP, XSLFILENAMEONLYREP,
                                                     BROWSER, XMLFILENAMEPATHREP);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Database error: " + exc.Message);

            }
        }

        private void allCustomersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    public class Customer
    {
        public int CNum { get; set; }
        public string CName { get; set; }
        public string CPhone { get; set; }
        public string CRepName { get; set; }
        
    }

    [Serializable]
    public class Rep
    {
        public string RNum { get; set; }
        public string RName { get; set; }
        public double RSalary { get; set; }
        
    }
}
