using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.BL.Models
{
    public class WeatherModel
    {
        public class Currently
        {
            public string Icon { get; set; }
            public double Temperature { get; set; }
            public double ApparentTemperature { get; set; }
            public double Humidity { get; set; }
            public double Pressure { get; set; }
            public double WindSpeed { get; set; }
            public double Visibility { get; set; }
            public double TemperatureHigh { get; set; }
            public double TemperatureLow { get; set; }
        }
        public class WeatherServiceBLInfo
        {
            public Currently currently { get; set; }
        }
    }
}
