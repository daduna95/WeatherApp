using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.BL.Models;
using static Weather.BL.Models.WeatherModel;

namespace Weather.BL.Services
{
    public class WeatherServiceBL : IWeatherService
    {
        readonly string baseUrl = "https://api.darksky.net/forecast/c7273b193cec8f2bfe4fcbb9cbae22f1/";
        public async Task<WeatherServiceBLInfo> weatherModel(double lat, double lon)
        {
           using (var client = new HttpClient())
            {
                var requestUrl = $"{baseUrl}{lat},{lon}";
                var response = await client.GetAsync(requestUrl);
                var content = await response.Content.ReadAsStringAsync();
                var weatherInfo = JsonConvert.DeserializeObject<WeatherServiceBLInfo>(content);
                return weatherInfo;
            }
         
        }
    }
}
