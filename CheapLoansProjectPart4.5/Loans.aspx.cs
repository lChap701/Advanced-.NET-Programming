using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheapLoansProjectPart4._5
{
    /// <summary>
    /// Created 4/6/2021 by Lucas Chapman.
    /// Client for interacting with the GetAllLoans() method in the LoanService class.
    /// </summary>
    public partial class Loans : Page
    {
        readonly localhost.LoanService loanService = new localhost.LoanService();

        /// <summary>
        /// Used to contain code or perform any actions after the page has loaded
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LoanGridViewCheck();
        }

        /// <summary>
        /// Saves the index of the selected row in the GridView and determines if the ScrollScript should be added
        /// </summary>
        void LoanGridViewCheck()
        {
            // Saves the original selected row index in session storage
            Session["SelectedRow"] = LoansGridView.SelectedIndex;

            // Checks if the ClearScript needs to be added and if the page has just loaded
            if (!IsPostBack)
            {
                if (!ClientScript.IsStartupScriptRegistered(GetType(), "ClearScript"))
                {
                    string script = "window.addEventListener('load', () => { localStorage.removeItem('gridview-scroll'); });";

                    ClientScript.RegisterStartupScript(GetType(), "ClearScript", script, true);
                }
            }

            // Checks if the ScrollScript or RemoveScript needs to be added
            if (!ClientScript.IsStartupScriptRegistered(GetType(), "ScrollScript") && LoansGridView.Rows.Count > 6)
            {
                string script = "document.getElementsByClassName('col')[0].id = 'scroll';\n";
                script += "const gv = document.getElementById('scroll');\nvar el = document.querySelector('.row, .selected, .asc, .desc');\n";
                script += "let pos = localStorage.getItem('gridview-scroll');\n";
                script += "if (pos !== null && el !== null) { gv.scrollTop = parseInt(pos, 10); }\n";
                script += "window.addEventListener('beforeunload', () => { localStorage.setItem('gridview-scroll', gv.scrollTop); });";

                ClientScript.RegisterStartupScript(GetType(), "ScrollScript", script, true);
            }
            else if (!ClientScript.IsStartupScriptRegistered(GetType(), "RemoveScript") && 
                LoansGridView.Rows.Count <= 6)
            {
                string script = "document.getElementsByClassName('col')[0].id = '';\n";
                ClientScript.RegisterStartupScript(GetType(), "RemoveScript", script, true);
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions when a row is selected
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void LoansGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determines if a row should be selected
            if (LoansGridView.SelectedIndex == int.Parse(Session["SelectedRow"].ToString()))
            {
                // Clears the selected row when it has been selected again
                LoansGridView.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions while sorting
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void LoansGridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            // Gets all loans
            var loans = JsonConvert.DeserializeObject<List<Loan>>(loanService.GetAllLoans());

            if (Session["PrevSortDirection"] != null &&
                !string.IsNullOrEmpty(e.SortExpression))
            {
                e.SortDirection = Session["PrevSortDirection"].ToString().Equals("desc") ? SortDirection.Descending
                : SortDirection.Ascending;
            }

            Session["PrevSortDirection"] = e.SortDirection == SortDirection.Ascending ? "desc" : "asc";

            // Sorts data in the GridView
            switch (e.SortExpression)
            {
                case "":
                case "LoanNum":
                    if (e.SortDirection == SortDirection.Ascending)
                    {
                        LoansGridView.DataSource = loans.OrderBy(l => l.LoanNum);
                    }
                    else
                    {
                        LoansGridView.DataSource = loans.OrderByDescending(l => l.LoanNum);
                    }
                    break;
                case "CustName":
                    if (e.SortDirection == SortDirection.Ascending)
                    {
                        LoansGridView.DataSource = loans.OrderBy(l => l.CustName);
                    }
                    else
                    {
                        LoansGridView.DataSource = loans.OrderByDescending(l => l.CustName);
                    }
                    break;
                case "LoanAmount":
                    if (e.SortDirection == SortDirection.Ascending)
                    {
                        LoansGridView.DataSource = loans.OrderBy(l => l.LoanAmount);
                    }
                    else
                    {
                        LoansGridView.DataSource = loans.OrderByDescending(l => l.LoanAmount);
                    }
                    break;
                case "AnnualIntRate":
                    if (e.SortDirection == SortDirection.Ascending)
                    {
                        LoansGridView.DataSource = loans.OrderBy(l => l.AnnualIntRate);
                    }
                    else
                    {
                        LoansGridView.DataSource = loans.OrderByDescending(l => l.AnnualIntRate);
                    }
                    break;
                case "NumPayments":
                    if (e.SortDirection == SortDirection.Ascending)
                    {
                        LoansGridView.DataSource = loans.OrderBy(l => l.NumPayments);
                    }
                    else
                    {
                        LoansGridView.DataSource = loans.OrderByDescending(l => l.NumPayments);
                    }
                    break;
            }

            LoansGridView.DataBind();
            Reset.Enabled = true;
        }

        /// <summary>
        /// Used to contain code or perform any actions when clicking the ViewData Button
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void ViewData_Click(object sender, EventArgs e)
        {
            // Hides the message
            HelpMsg.Visible = false;

            // Disables the ViewData Button
            ViewData.Enabled = false;

            try
            {
                // Attempts to retrieves data in the GridView
                string loansJson = loanService.GetAllLoans();

                // Determines what should be displayed
                if (loansJson.Contains("Nothing to display"))
                {
                    // Displays a label that displays a message
                    Msg.Text = loansJson;
                    Msg.Visible = true;
                }
                else
                {
                    Msg.Visible = false;

                    // Displays the data that is retrieved by the service in the GridView
                    LoansGridView.DataSource = JsonConvert.DeserializeObject<List<Loan>>(loansJson);
                    LoansGridView.DataBind();

                    LoanGridViewCheck();
                }
            }
            catch (Exception ex)
            {
                // Displays an error message (both on the web page and in the console)
                Msg.Visible = true;
                Msg.Text = "Unable to display loans, please come back later!";
                ClientScript.RegisterClientScriptBlock(GetType(), "ErrorMsgScript", "console.error('" + ex.Message
                    + "');", true);
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions when clicking the Reset Button
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void Reset_Click(object sender, EventArgs e)
        {
            // Resets the form
            LoansGridView.Sort("", SortDirection.Ascending);
            LoansGridView.SelectedIndex = -1;
            Reset.Enabled = false;
        }
    }
}