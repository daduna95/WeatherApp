using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BL.Models;
using static Weather.BL.Models.WeatherModel;

namespace Weather.BL.Services
{
   public interface IWeatherService
    {
        Task<WeatherServiceBLInfo> weatherModel(double lat, double lon);
        
    }
}
