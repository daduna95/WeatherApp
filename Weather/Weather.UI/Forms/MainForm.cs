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
            WeatherServiceBL servicetest = new WeatherServiceBL();
            var datatest = await servicetest.weatherModel(41.7151, 44.8271);
    


            CurrentTemperature_Label.Text = datatest.currently.Temperature.ToString();
            HighestTemperature_Label.Text = datatest.daily.temperatureMax.ToString();
            LowestTemperature_Label.Text = datatest.daily.temperatureMin.ToString();
            FeelsLikePercentage_Label.Text = datatest.currently.ApparentTemperature.ToString();
            WeatherIcon_PictureBox.ImageLocation = datatest.currently.Icon;
            WindSpeed_Label.Text = datatest.currently.WindSpeed.ToString();
            HumidityPercentage_Label.Text = datatest.currently.Humidity.ToString();
            VisibilityDistance_Label.Text = datatest.currently.Humidity.ToString();
            PressurePower_Label.Text = datatest.currently.Pressure.ToString();
        }
    }
}
