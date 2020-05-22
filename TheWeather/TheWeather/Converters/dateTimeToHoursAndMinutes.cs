using NodaTime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TheWeather.Converters
{
    class dateTimeToHoursAndMinutes: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (DateTime)value;
            return valor.ToString("t",
                  CultureInfo.CreateSpecificCulture("es-ES"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = (string)value;
            return valor.Remove(0);
        }

    }   
}
