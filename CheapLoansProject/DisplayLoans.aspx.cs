using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CheapLoansProject
{
    /// <summary>
    /// The class for displaying DisplayLoans.aspx
    /// </summary>
    public partial class DisplayLoans : Page
    {
        static bool displayed = false;

        /// <summary>
        /// Used to contain code or perform any actions after the page has loaded
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            double total = 0.00;

            // Gets all of the loan amounts
            var rows = GridViewLoans.Rows.Cast<GridViewRow>()
                .Where(r => r.Cells[3].Text.Contains("$")).ToList();

            // Loops through all of the rows in the GridView
            foreach (GridViewRow row in rows)
            {
                // Accumlates the total loan amout
                total += double.Parse(row.Cells[3].Text.Replace("$", "").Replace(",", ""));
            }

            // Displays the total
            Total.Text = total.ToString("#,###,###,###,###,##0.00");

            // Saves the original selected row index in session storage
            Session["SelectedRow"] = GridViewLoans.SelectedIndex;

            // Checks if the ScrollScript needs to be added and if GridViewLoans should have a scrollbar add to it
            if (!ClientScript.IsStartupScriptRegistered(GetType(), "ScrollScript") && GridViewLoans.Rows.Count > 9)
            {
                string script = "document.getElementsByClassName('col')[0].id = 'scroll';\n";
                script += "const gv = document.getElementById('scroll');\nvar el = document.querySelector('.Row, .Selected, .Asc, .Desc');\n";
                script += "let pos = localStorage.getItem('gridview-scroll');\n";
                script += "if (pos !== null && el !== null) { gv.scrollTop = parseInt(pos, 10); }\n";
                script += "window.addEventListener('beforeunload', () => { localStorage.setItem('gridview-scroll', gv.scrollTop); });";

                ClientScript.RegisterStartupScript(GetType(), "ScrollScript", script, true);
            }

            // Check to see if the WelcomeScript is already registered and has not been displayed before
            if (!ClientScript.IsStartupScriptRegistered(GetType(), "WelcomeScript") && !displayed)
            {
                ClientScript.RegisterStartupScript(GetType(), "WelcomeScript", "alert('Welcome to the Display Loans form!');", true);
                displayed = true;
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions when a row is selected
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void GridViewLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determines if a row should be selected
            if (GridViewLoans.SelectedIndex == int.Parse(Session["SelectedRow"].ToString()))
            {
                // Clears the selected row when it has been selected again
                GridViewLoans.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions after sorting
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        protected void GridViewLoans_Sorted(object sender, EventArgs e)
        {
            // Determines if the Reset button should be enabled
            if (!string.IsNullOrEmpty(GridViewLoans.SortExpression))
            {
                Reset.Enabled = true;
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
            GridViewLoans.Sort("", SortDirection.Ascending);
            GridViewLoans.SelectedIndex = -1;
            Reset.Enabled = false;
        }
    }
}