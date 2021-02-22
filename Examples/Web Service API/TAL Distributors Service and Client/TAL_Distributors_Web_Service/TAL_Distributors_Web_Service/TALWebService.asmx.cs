using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TAL_Distributors_Web_Service
{
    /// <summary>
    /// Summary description for TALWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TALWebService : System.Web.Services.WebService
    {

        /// <summary>
        /// Returns all customers from the database (no parameter)+
        /// </summary>
        /// <returns>string</returns>
        [WebMethod]
        public string GetCustomers()
        {
            using (TAL_DistributorsEntities context = new TAL_DistributorsEntities())
            {                

                //Get the List of Customers from the database
                var custList = (from c in context.CUSTOMERs
                                select c).ToList<CUSTOMER>();

                //custList.Clear(); //this was used to test the table empty return

                if (custList.Count > 0)
                {
                    return JsonConvert.SerializeObject(custList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }

               
            }
        }

        /// <summary>
        /// Returns a single customer based on the customer number passed
        /// </summary>
        /// <param name="num"></param>
        /// <returns>string</returns>
        [WebMethod]
        public string GetSingleCustomer(string num)
        {
            using (TAL_DistributorsEntities context = new TAL_DistributorsEntities())
            {              

                //Get the List of Customers from the database
                var custList = (from c in context.CUSTOMERs
                                where c.CUSTOMER_NUM == num
                                select c).ToList<CUSTOMER>();

                if (custList.Count > 0)
                {
                   return JsonConvert.SerializeObject(custList, Formatting.Indented,
                                  new JsonSerializerSettings()
                                  {
                                      ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                  });
                }
                else
                {
                    return "No such customer";
                }
            }
        }
    }
}
