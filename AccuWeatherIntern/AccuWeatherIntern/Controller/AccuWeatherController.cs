using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccuWeatherIntern.Controller
{
    public class AccuWeatherController
    {
        public string ApiKey { get; set; }
        public bool Metric { get; set; }
        public bool Daily { get; set; }
        public string SearchValue { get; set; }
        public string CityCode { get; set; }


        public string GetUrl()
        {
            string result = "http://dataservice.accuweather.com/forecasts/v1/";
            result += (Daily ? "daily" : "hourly");
            result += ("/" + SearchValue + (Daily ? "day" : "hour"));
            result += ("/" + CityCode);
            result += "?apikey=" + ApiKey;
            result += ("&metric=" + Metric.ToString().ToLower());
            return result;
        }
    }
}
