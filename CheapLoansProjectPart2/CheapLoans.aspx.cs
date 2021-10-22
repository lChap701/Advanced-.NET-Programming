using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace CheapLoansProject
{
    /// <summary>
    /// Created 3/1/2021 by Lucas Chapman.
    /// The class for displaying and handling actions performed by users for CheapLoans.aspx using a stored procedure to store data.
    /// </summary>
    public partial class CheapLoans : Page
    {
        static bool displayed = false;

        /// <summary>
        /// Used to contain code or perform any actions after the page has loaded
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Contains some code that was based on http://www.dotnetvishal.com/2012/10/avoid-duplicate-record-insertion-on.html
        /// </remarks>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sets the MonPayment textbox to a default value
            MonPayment.Text = "0.00";

            // Checks if the FormatScript needs to be added
            if (!ClientScript.IsStartupScriptRegistered(GetType(), "FormatScript"))
            {
                ClientScript.RegisterStartupScript(GetType(), "FormatScript", "<script defer src='/js/FormatData.js'></script>");
            }

            // Checks if postback (submit) has occurred to display messages and stores data in session storage
            if (!IsPostBack)
            {
                // Check to see if the WelcomeScript is already registered and has not been displayed before
                if (!ClientScript.IsStartupScriptRegistered(GetType(), "WelcomeScript") && !displayed)
                {
                    string scriptWelcome = "alert('Welcome to the Cheap Loans form!');";
                    ClientScript.RegisterStartupScript(GetType(), "WelcomeScript", scriptWelcome, true);
                    displayed = true;
                }

                // Checks if the ScrollScript needs to be added
                if (!ClientScript.IsStartupScriptRegistered(GetType(), "ScrollScript"))
                {
                    string scriptScroll = "window.addEventListener('load', () => { localStorage.clear() });";
                    ClientScript.RegisterStartupScript(GetType(), "ScrollScript", scriptScroll, true);
                }

                // Used to prevent the SQL INSERT statement from running when reloading the page
                Session["date"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions when the page is being pre-rendered
        /// </summary>
        /// <param name="obj">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on http://www.dotnetvishal.com/2012/10/avoid-duplicate-record-insertion-on.html
        /// </remarks>
        void Page_PreRender(object obj, EventArgs e)
        {
            // Will be compared later
            ViewState["date"] = Session["date"];
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the Submit button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            // Calculates the monthly payment
            if (!string.IsNullOrEmpty(CustName.Text.Trim()) && double.TryParse(LoanAmt.Text, out double loanAmt) &&
                double.TryParse(AnnualIntRate.Text, out double anIntRate) &&
                int.TryParse(NumPayments.Text, out int numPayments))
            {
                MonPayment.Text = Calc(anIntRate, numPayments, loanAmt);
            }
        }

        /// <summary>
        /// Calculates the monthly payment
        /// </summary>
        /// <param name="rate">Represents the annual interest rate</param>
        /// <param name="payments">Represents the number of payments</param>
        /// <param name="amt">Represents the loan amount</param>
        /// <returns>Returns the result that was calculated as a string, so the value can be formatted and displayed as text</returns>
        /// <remarks>
        /// Created in order to be tested in unit tests
        /// </remarks>
        public static string Calc(double rate, double payments, double amt)
        {
            return Math.Round(-Financial.Pmt(rate / 100, payments, amt), 2).ToString("###,##0.00");
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the Reset button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void Reset_Click(object sender, EventArgs e)
        {
            // Clears all values in the form and removes error messages
            CustName.Text = "";
            RequiredFieldValidatorCustName.IsValid = true;
            RegularExpressionValidatorCustName.IsValid = true;

            LoanAmt.Text = "";
            RequiredFieldValidatorLoanAmt.IsValid = true;
            RangeValidatorLoanAmt.IsValid = true;

            AnnualIntRate.Text = "";
            RequiredFieldValidatorAnnualIntRate.IsValid = true;
            RangeValidatorAnnualIntRate.IsValid = true;

            NumPayments.Text = "";
            RequiredFieldValidatorNumPayments.IsValid = true;
            RangeValidatorNumPayments.IsValid = true;
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the Save button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Contains some code that was based on http://www.dotnetvishal.com/2012/10/avoid-duplicate-record-insertion-on.html
        /// </remarks>
        protected void Save_Click(object sender, EventArgs e)
        {
            // Determines if the procedure should be ran
            if (Session["date"].ToString().Equals(ViewState["date"].ToString()))
            {
                // Stores loans in the database
                SqlDataSourceCheapLoans.Insert();

                // Updates the Session object
                Session["date"] = Server.UrlEncode(System.DateTime.Now.ToString());
            }

            // Clears values
            CustName.Text = "";
            LoanAmt.Text = "";
            AnnualIntRate.Text = "";
            NumPayments.Text = "";
        }

        /// <summary>
        /// Used to conatin code or perform any actions that need to be done in order to run the procedure successfully
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void SqlDataSourceCheapLoans_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {
            // Gets the command and stores it in variable
            var command = e.Command;

            try
            {
                // Corrects the properties of parameters
                command.Parameters["@LoanAmount"].Precision = 9;
                command.Parameters["@AnnualIntRate"].Precision = 3;
                command.Parameters["@AnnualIntRate"].Scale = 3;

                // Corrects the value in @AnnualIntRate
                decimal anIntRate = decimal.Parse((command.Parameters["@AnnualIntRate"].Value.ToString()));
                command.Parameters["@AnnualIntRate"].Value = anIntRate / 100;
            }
            catch (Exception ex)
            {
                // Displays error messages and cancels the SQL INSERT statement when expections are caught
                string scriptError = "alert('Unable to save loan due to a serious error');\n";
                scriptError += "console.error('" + ex.Message + "');";
                ClientScript.RegisterClientScriptBlock(GetType(), "ErrorScript", scriptError, true);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Used to conatin code or perform any actions that need to be done after successfully running the procedure
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void SqlDataSourceCheapLoans_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(GetType(), "ConfirmScript", "alert('The loan has been saved');", true);
        }
    }
}