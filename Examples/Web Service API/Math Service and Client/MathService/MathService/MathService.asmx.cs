/* This project is a web service for doing basic math on 2 numbers,
 * that runs on localhost.
 * It must be started (listening) before clients can connect to the methods.
 * 
 */

using System.Web.Services;

namespace MathService
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double a, double b)
        {
            return (a + b);
        }

        [WebMethod]
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        [WebMethod]
        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        [WebMethod]
        public double Divide(double a, double b)
        {
            if (b == 0)
                return -1;
            else
                return a / b;
        }
    }
}
