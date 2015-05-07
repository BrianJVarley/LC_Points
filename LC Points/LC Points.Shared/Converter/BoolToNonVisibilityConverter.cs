using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace LC_Points.Converter
{
    class BoolToNonVisibilityConverter : IValueConverter
    {
       
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // Do the conversion from bool to visibility
            bool bValue = (bool)value;
            if (bValue)
                return Visibility.Collapsed;
            else
                return Visibility.Visible;

            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            // Do the conversion from visibility to bool
            Visibility visibility = (Visibility)value;

            if (visibility == Visibility.Collapsed)
                return true;
            else
                return false;

            throw new NotImplementedException();
        }
    }
}
