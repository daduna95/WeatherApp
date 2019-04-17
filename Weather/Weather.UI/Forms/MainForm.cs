using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather.BL.Services;
using Weather.WebClient.Services;

namespace Weather.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            //WeatherService service = new WeatherService();
            //var data = await service.GetWeatherData(41.7151, 44.8271);
            WeatherServiceBL servicetest = new WeatherServiceBL();
            var datatest = await servicetest.weatherModel(37.8267, -122.4233);
        }
    }
}
