using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.BL.Utils
{
    static class WeatherConfig
    {
        public static  SelectedTemperature SelectedTemperature { get; set; }
    }

    public enum SelectedTemperature
    {
        Celcius,
        Farenheit
    }
    public struct Temperature
    {
        double celcius => (farenheit - 32) * 5/9;
        double farenheit;
        


        public static implicit operator Temperature(double value)
        {
            return new Temperature { farenheit = value };
        }
        public static implicit operator double(Temperature value)
        {
            switch(WeatherConfig.SelectedTemperature)
            {
                case SelectedTemperature.Celcius: return value.celcius;
                case SelectedTemperature.Farenheit: return value.farenheit;
                default: return value.celcius;
            }
        }
        public override string ToString()
        {
            switch (WeatherConfig.SelectedTemperature)
            {
                case SelectedTemperature.Celcius: return $"{Math.Round(celcius)}";
                case SelectedTemperature.Farenheit: return $"{ Math.Round(celcius)}";
                default: return $"{Math.Round(celcius)}";
            }
        }
    }
}
