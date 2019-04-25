using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.BL.Models;
using Weather.WebClient.DTOs;

namespace Weather.WebClient.Services
{
    public class WeatherService
    {
        readonly string baseUrl = "https://api.darksky.net/forecast/c7273b193cec8f2bfe4fcbb9cbae22f1/";

        private async Task<WeatherInfo> GetWeatherData(double lat, double lon)
        {
            using (var client = new HttpClient())
            {
                var requestUrl = $"{baseUrl}{lat},{lon}";
                var response = await client.GetAsync(requestUrl);
                var content = await response.Content.ReadAsStringAsync();
                var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(content);
                return weatherInfo;
            }
        }

        public async Task<WeatherModel> GetWeatherModel(double lat, double lon)
        {
           var data= await GetWeatherData(lat, lon);
            var result = new WeatherModel
            {
                ApparentTemperature = data.currently.apparentTemperature,
                Humidity = data.currently.humidity,
                Currenttemperature = data.currently.temperature,
                Pressure = data.currently.pressure,
                WindSpeed = data.currently.windSpeed,
                Visibility = data.currently.visibility,
                temperatureMax = data.daily.data[0].temperatureMax,
                temperatureMin = data.daily.data[0].temperatureMin
                
                
            };

            return result;
            
       }
    }
}
