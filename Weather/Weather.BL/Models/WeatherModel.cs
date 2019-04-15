using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.BL.Models
{
    public class WeatherModel
    {
        public string icon { get; set; }
        public double temperature { get; set; }
        public double apparentTemperature { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double visibility { get; set; }
        public double temperatureHigh { get; set; }
        public double temperatureLow { get; set; }
    }
}
