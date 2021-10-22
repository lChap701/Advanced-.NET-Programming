using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace ConsumingWebServiceExample1
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        //consume the weather underground api in xml format
        private void btnShowWeather_Click(object sender, EventArgs e)
        {
            //weatherundergroud return variables
            string place = "";
            string obs_time = "";
            string weather1 = "";
            string temperature_string = "";
            string relative_humidity = "";
            string wind_string = "";
            string pressure_mb = "";
            string dewpoint_string = "";
            string visibility_km = "";
            string latitude = "";
            string longitude = "";
              
            //weatherunderground key and required parameter string          
            String wuKey = "79af2f17794bd752";
            String input_xml = "http://api.wunderground.com/api/" + wuKey + "/conditions/q/" + 
                txtState.Text + "/" + txtCity.Text + ".xml";

            //call the API
            var cli = new WebClient();
            string weather = cli.DownloadString(input_xml);

            //parse thru the XML return data
            using (XmlReader reader = XmlReader.Create(new StringReader(weather)))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name.Equals("full"))
                            {
                                reader.Read();
                                place = reader.Value;
                            }
                            else if (reader.Name.Equals("observation_time"))
                            {
                                reader.Read();
                                obs_time = reader.Value;
                            }
                            else if (reader.Name.Equals("weather"))
                            {
                                reader.Read();
                                weather1 = reader.Value;
                            }
                            else if (reader.Name.Equals("temperature_string"))
                            {
                                reader.Read();
                                temperature_string = reader.Value;
                            }
                            else if (reader.Name.Equals("relative_humidity"))
                            {
                                reader.Read();
                                relative_humidity = reader.Value;
                            }
                            else if (reader.Name.Equals("wind_string"))
                            {
                                reader.Read();
                                wind_string = reader.Value;
                            }
                            else if (reader.Name.Equals("pressure_mb"))
                            {
                                reader.Read();
                                pressure_mb = reader.Value;
                            }
                            else if (reader.Name.Equals("dewpoint_string"))
                            {
                                reader.Read();
                                dewpoint_string = reader.Value;
                            }
                            else if (reader.Name.Equals("visibility_km"))
                            {
                                reader.Read();
                                visibility_km = reader.Value;
                            }
                            else if (reader.Name.Equals("latitude"))
                            {
                                reader.Read();
                                latitude = reader.Value;
                            }
                            else if (reader.Name.Equals("longitude"))
                            {
                                reader.Read();
                                longitude = reader.Value;
                            }

                            break;
                    }
                }
            }

            //place the data on the form
            txtWeather.Text = "*********************" + Environment.NewLine +
                              "Place:             " + place + Environment.NewLine +
                              "Observation Time:  " + obs_time + Environment.NewLine +
                              "Weather:           " + weather1 + Environment.NewLine +
                              "Temperature:       " + temperature_string + Environment.NewLine +
                              "Relative Humidity: " + relative_humidity + Environment.NewLine +
                              "Wind:              " + wind_string + Environment.NewLine +
                              "Pressure (mb):     " + pressure_mb + Environment.NewLine +
                              "Dewpoint:          " + dewpoint_string + Environment.NewLine +
                              "Visibility (km):   " + visibility_km + Environment.NewLine +
                              "Location:          " + longitude + ", " + latitude;
        }
    }
}
