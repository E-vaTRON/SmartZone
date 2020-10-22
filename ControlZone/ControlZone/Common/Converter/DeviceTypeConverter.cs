using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ControlZone.Common.Converter
{
    class DeviceTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string deviceType = String.Empty;
            int type = (int)value;
            switch (type)
            {
                case 0:
                    deviceType = "Trung tâm điều khiển";
                    break;
                case 1:
                    deviceType = "Thùng rác";
                    break;
            }
            return deviceType;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
