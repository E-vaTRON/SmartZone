using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ControlZone.Common.Converter
{
    public sealed class DeviceProcessTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string overallProcess = String.Empty;
            Label deviceType = (object)parameter as Label;
            if(deviceType.Text == "Trung tâm điều khiển")
            {
                overallProcess = "Xung nhịp CPU: " + (float)value;
            }
            else if(deviceType.Text == "Thùng rác")
            {
                overallProcess = "Lượng rác: " + (float)value;
            }
            else
            {
                overallProcess = "Trạng thái: " + (float)value;
            }
            return overallProcess;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
