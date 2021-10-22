/* This program prompts for 2 numbers and performs basic math.
 * The math methods for Add, Subtract, Multiply and Divide
 * reside in a Web Service called MathService that runs on the local
 * server (localhost).
 * This web service must be listening before this program can be executed.
 * Be sure to load project MathService and press Start to enable listening 
 */

using System;

namespace MathServiceASPClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {          
            //instantiate a proxy object in order to expose methods
            localhost.MathService myMathService = new localhost.MathService();

            double num1, num2;

            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);

            txtAdd.Text = myMathService.Add(num1, num2).ToString();
            txtSub.Text = myMathService.Subtract(num1, num2).ToString();
            txtMult.Text = myMathService.Multiply(num1, num2).ToString();
            txtDiv.Text = myMathService.Divide(num1, num2).ToString();

        }
    }
}