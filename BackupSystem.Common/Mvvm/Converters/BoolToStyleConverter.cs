using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace BackupSystem.Common.Mvvm.Converters
{
    [ValueConversion(typeof(bool), typeof(Style))]
    public class BoolToStyleConverter : IValueConverter
    {
        /// <summary>
        /// Converts Boolean to a certain style (passed in).
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Style style = null;
            bool result = false; // Default is false
            if (value != null)
            {
                bool.TryParse(value.ToString(), out result);
            }

            if (parameter != null && parameter.ToString().Contains("|"))
            {
                var styleArr = parameter.ToString().Split('|');
                if (result)
                {
                    style = Application.Current.TryFindResource(styleArr[0]) as Style;
                }
                else
                {
                    style = Application.Current.TryFindResource(styleArr[1]) as Style;
                }
            }

            return style;
        }

        /// <summary>
        /// Convert back, but its not implemented as it's not yet needed
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
