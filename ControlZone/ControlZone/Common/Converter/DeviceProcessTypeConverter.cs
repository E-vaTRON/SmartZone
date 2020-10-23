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
            float floatvalue = (float)value * 100f;
            Label deviceType = (object)parameter as Label;
            if(deviceType.Text == "Trung tâm điều khiển")
            {
                overallProcess = "Xung nhịp CPU: " + floatvalue + "%";
            }
            else if(deviceType.Text == "Thùng rác")
            {
                overallProcess = "Lượng rác: " + floatvalue + "%";
            }
            else if(deviceType.Text == "Đèn")
            {
                overallProcess = "Độ sáng: " + floatvalue + "%";
            }
            else
            {
                overallProcess = "Trạng thái: " + floatvalue + "%";
            }
            return overallProcess;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
