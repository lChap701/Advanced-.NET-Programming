using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumingWebServiceExample1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            Weather weatherForm = new Weather();
            weatherForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quotes quoteForm = new Quotes();
            quoteForm.ShowDialog();
        }
    }
}
