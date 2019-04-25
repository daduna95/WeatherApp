using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            WeatherService servicetest = new WeatherService();
            var datatest = await servicetest.GetWeatherModel(41.716667, 44.783333);
            CurrentTemperature_Label.Text = datatest.Temperature.ToString();
            FeelsLikePercentage_Label.Text = datatest.ApparentTemperature.ToString();
            WindSpeed_Label.Text = datatest.WindSpeed.ToString();
            HumidityPercentage_Label.Text = datatest.WindSpeed.ToString();
            PressurePower_Label.Text = datatest.Pressure.ToString();
            VisibilityDistance_Label.Text = datatest.Visibility.ToString();
            LowestTemperature_Label.Text = datatest.temperatureMin.ToString();
            HighestTemperature_Label.Text = datatest.temperatureMax.ToString();
   
        }
    }
}
