using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace LC_Points.Converter
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // Do the conversion from bool to visibility
            bool bValue = (bool)value;
            if (bValue)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            // Do the conversion from visibility to bool
            Visibility visibility = (Visibility)value;

            if (visibility == Visibility.Visible)
                return true;
            else
                return false;

            throw new NotImplementedException();
        }
    }
}
