using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace MainApp.Converter
{
    public class TextNewLineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value as string;
            if (text == null)
            {
                return value;
            }

            return Regex.Replace(text, "<[Bb][Rr]>", "\n");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
