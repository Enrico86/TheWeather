using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheWeather.Model;
using Xamarin.Forms;

namespace TheWeather.ViewModel
{
    public class WeatherPageViewModel : INotifyPropertyChanged
    {
        
        private WeatherData data;
        public WeatherData Data
        {
            get => data; 
            set
            {
                data = value;
                OnPropertyChanged();
            }
        }

        public ICommand SearchCommand { get; set; }

        public WeatherPageViewModel()
        {
            SearchCommand = new Command(async (searchTerm) =>
            {

                var entrada = searchTerm as string;
                var datos = entrada.Split(',');
                var latitud = datos[0];
                var longitud = datos[1];
                await GetData($"https://api.weatherbit.io/v2.0/current?lat={latitud}&lon={longitud}&lang=it&key=ac9a6a532ebb4b0685dde7ccec3ae9ce");
            });
        }
        #region
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private async Task GetData(string url)
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
