using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWithDatabaseExample
{
    public partial class _default : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters.Add("WidgetName", TypeCode.String, "Elf Wisdom");
            SqlDataSource1.InsertParameters.Add("WidgetPrice", TypeCode.Decimal, "27.50");
            SqlDataSource1.InsertParameters.Add("WidgetDept", TypeCode.String, "1");

            try
            {
                SqlDataSource1.Insert();
            }
            catch (Exception exc)
            {
                Response.Write("<script type=\"text/javascript\">alert(\"Error retrieving data" + 
                    exc.Message + "\");</script");
            }
        }
    }
}