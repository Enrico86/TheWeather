using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
                await GetData("https://api.weatherbit.io/v2.0/current?lat=41.3887901&lon=2.1589899&key=ac9a6a532ebb4b0685dde7ccec3ae9ce");
            });
        }

        private async Task GetData (string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WeatherData>(jsonResult);
            Data = result;
        }

    }
}
