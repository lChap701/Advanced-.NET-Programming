using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aquarium_Csharp
{
    public partial class _default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            // displays number of gallons

            double length, width, height, volume, gallons;


            Double.TryParse(lengthTextBox.Text, out length);
            Double.TryParse(widthTextBox.Text, out width);
            Double.TryParse(heightTextBox.Text, out height);

            volume = length * width * height;
            gallons = volume / 231;
            gallonsLabel.Text = gallons.ToString("N1");
        }

    }
}