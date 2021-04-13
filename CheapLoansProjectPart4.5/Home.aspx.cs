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
    /// The Home page for this project which gives a run down of how this project works.
    /// </summary>
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheapLoansEntities cheapLoans = new CheapLoansEntities();

            // Gets the total number of loans in the database
            int count = (from loans in cheapLoans.Loans
                         select loans).Count();

            // Determines what message should be displayed
            if (count == 0)
            {
                Indicator.Text = "This site is currently unable to show any loans at this time, please come back later!";
            }
            else if (count == 1)
            {
                Indicator.Text = "There is currently only " + count + " loan to display, feel free to comeback later!";
            }
            else
            {
                Indicator.Text = "There is currently " + count + " loans to display!";
            }

            // Displays the current date and time (in a 12-hour format)
            Date.Text = DateTime.Now.AddTicks(-(DateTime.Now.Ticks % TimeSpan.TicksPerSecond)).ToString();
        }
    }
}