using AccuWeatherIntern.Controller;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;


namespace AccuWeatherIntern
{
    public partial class Form1 : Form
    {
        private int[] _hours = new int[] { 1, 12};
        private int[] _days = new int[] { 1, 5 };
      

        public Form1()
        {
            InitializeComponent();
        }

        private void windowsLocationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PanelCityCode.Visible = !WindowsLocationRadioButton.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in _hours)
            {
                HoursDropDown.Items.Add(item);
            }
            HoursDropDown.SelectedIndex = 0;
            foreach (var item in _days)
            {
                DaysComboBox.Items.Add(item);
            }
            DaysComboBox.SelectedIndex = 0;
        }

        private void hoursRadioButton_CheckedChanged(object sender, EventArgs e)
        {          
            HoursDropDown.Visible = !DaysDropDown.Checked;
            DaysComboBox.Visible = !HoursRadioButton.Checked;           
         }

        private void getForecastButton_Click(object sender, EventArgs e)
        { 
            AccuWeatherController controller = new AccuWeatherController();
            controller.ApiKey = "hAsmrmAMTPIhOqtl4v0gQRdicBODHpzT";
            controller.CityCode = "49959";
            controller.Metric = TemperatureCRadioButton.Checked;
            controller.Daily = DaysDropDown.Checked;
            controller.SearchValue = DaysDropDown.Checked ? DaysComboBox.Items[DaysComboBox.SelectedIndex].ToString() : HoursDropDown.Items[HoursDropDown.SelectedIndex].ToString();


            textBox1.Text = new WebClient().DownloadString(controller.GetUrl());
            textBox2.Text = "";

            BsonArray bsonDocument = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonArray>(textBox1.Text);
            foreach (var item in bsonDocument.AsBsonArray)
            {
                textBox2.Text += item["DateTime"] + "/" +item["IconPhrase"].ToString() +"/" + item["Temperature"]["Value"].AsDouble+item["Temperature"]["Unit"]+System.Environment.NewLine;
             
            }




            //
            // var desrialize = JsonConvert.DeserializeObject<Headline>(respnse);
            // dynamic result = JsonValue.Parse(WebClient.DownloadString("https://api.foursquare.com/v2/users/self?oauth_token=XXXXXXX"));

            //Dictionary<string, string>[] contacts = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(respnse);

            //MessageBox.Show(contacts[1][""]);      

            //
            //  var jsonVal = JArray.Parse(respnse) as JArray;
            /*  var jsonVal = JArray.Parse(respnse) as JArray;
              dynamic weather = jsonVal;


                 foreach (dynamic item in weather.Temperature)
                 {
                     MessageBox.Show(item.Maximum);
                 }

             // string output = JsonConvert.SerializeObject(respnse, Formatting.Indented);
             // MessageBox.Show(output);
             */
            //   Headline obj = JsonConvert.DeserializeObject<Headline>(respnse);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//HOW TO PARSE JSON TO C#