using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TheWeather.Converters
{

    public class FloatToDegrees : IValueConverter
    {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var valor = (float)value;
                return valor.ToString()+" Cº";
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                string valor = (string)value;
                return valor.Remove(2);
            }
        
    }

}

