using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CheapLoansProjectPart4
{
    /// <summary>
    /// Created 4/5/2021 by Lucas Chapman.
    /// Service for the Loans table in the Cheap Loans database.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    //[System.Web.Script.Services.ScriptService]
    public class LoanService : WebService
    {
        readonly CheapLoansEntities cheapLoans = new CheapLoansEntities();

        /// <summary>
        /// Retrieves all loans in the database
        /// </summary>
        /// <returns>All loans in the database or an error message</returns>
        [WebMethod]
        public string GetAllLoans()
        {
            // Gets all the loans in the CheapLoans database
            var loans = (from loan in cheapLoans.Loans
                         orderby loan.LoanNum
                         select loan).ToList();

            // Checks if there any loan is found
            if (loans.Count == 0)
            {
                return "Nothing to display";
            }

            return JsonConvert.SerializeObject(loans, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        /// <summary>
        /// Retrieves all loans in the database based on the name of customer
        /// </summary>
        /// <param name="name">Represents the name (or part of it) to search for</param>
        /// <returns>Loans in the database based on the value of the name or error messages</returns>
        [WebMethod]
        public string GetLoanByCustomer(string name)
        {
            // Checks if the name/value to search for is null or an empty string ("")
            if (string.IsNullOrEmpty(name.Trim()))
            {
                return "Nothing was entered";
            }

            // Gets all the loans in the CheapLoans database by customer name
            var loans = (from loan in cheapLoans.Loans
                         orderby loan.LoanNum
                         where loan.CustName.Contains(name.Trim())
                         select loan).ToList();

            // Checks if there any loan is found
            if (loans.Count == 0)
            {
                return "No customers were found";
            }

            return JsonConvert.SerializeObject(loans, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
    }
}
