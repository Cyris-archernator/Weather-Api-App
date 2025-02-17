using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace my_test_document
{
    public partial class MainTab : Form
    {
       
        Form OldForm;
        public MainTab(Form PreviousForm)
        {
            InitializeComponent();
            OldForm = PreviousForm;
        }

        private DateTime TIME;
        private string TEMP;
        private string WIND;
        private string RAIN;

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            OldForm.Show();
            this.Close();
        }

        private void btnreview_Click(object sender, EventArgs e)
        {
            string APIKey = "9031f4d8c80278427290c4f63b28199f";
            string Location =txtLocation.Text;
            string URL = $"http://api.openweathermap.org/data/2.5/forecast?&mode=xml&q={Location}&units=metric&APPID={APIKey}";
            
            WebClient client = new WebClient();

            DisplayForecast(client.DownloadString(URL));
        }

        private void DisplayForecast(string xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            // Get the city, country, latitude, and longitude.
            XmlNode locNode = xmlDoc.SelectSingleNode("weatherdata/location");
            txtLocation.Text = locNode.SelectSingleNode("name").InnerText;

            foreach (XmlNode timeNode in xmlDoc.SelectNodes("//time"))
            {
                // Get the time in UTC.
                TIME =
                    DateTime.Parse(timeNode.Attributes["from"].Value);

                // Get the temperature.
                XmlNode tempNode = timeNode.SelectSingleNode("temperature");
                TEMP = tempNode.Attributes["value"].Value;

                XmlNode windNode = timeNode.SelectSingleNode("windSpeed");
                WIND = windNode.Attributes["mps"].Value;

                XmlNode rainnode = timeNode.SelectSingleNode("precipitation");
                RAIN = rainnode.Attributes["probability"].Value;
                //Display the data





                ListViewItem listViewItem = new ListViewItem(TIME.DayOfWeek.ToString());
                listViewItem.SubItems.Add(TIME.ToShortTimeString());
                listViewItem.SubItems.Add(TEMP);
                listViewItem.SubItems.Add(WIND);
                listViewItem.SubItems.Add(RAIN);

                list.Items.Add(listViewItem);

            }

        }
    }
}
