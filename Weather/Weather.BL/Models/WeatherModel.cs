using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BL.Utils;

namespace Weather.BL.Models
{
    public class WeatherModel
    {
            public Temperature Currenttemperature { get; set; }
            public Temperature ApparentTemperature { get; set; }
            public double Humidity { get; set; }
            public double Pressure { get; set; }
            public double WindSpeed { get; set; }
            public double Visibility { get; set; }
            public Temperature temperatureMax { get; set; }
            public Temperature temperatureMin { get; set; }
    }
}
