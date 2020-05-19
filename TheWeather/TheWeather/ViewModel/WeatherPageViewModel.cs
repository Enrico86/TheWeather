using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheWeather.Model;
using Xamarin.Forms;

namespace TheWeather.ViewModel
{
    class WeatherPageViewModel
    {
        public WeatherData Data { get; set; }

        public ICommand SearchCommand { get; set; }

        public WeatherPageViewModel ()
        {
            SearchCommand = new Command(async () =>
            {
                await GetData("");
            });
        }

        private async Task 

    }
}
