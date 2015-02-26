using System;
using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WPAppStudio.Converters
{
    public class ThumbnailConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                var bm = new BitmapImage(new Uri(value.ToString()))
                         {
                             CreateOptions = BitmapCreateOptions.BackgroundCreation,
                             DecodePixelHeight = System.Convert.ToInt32(parameter)
                         };

                return bm;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }


            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
