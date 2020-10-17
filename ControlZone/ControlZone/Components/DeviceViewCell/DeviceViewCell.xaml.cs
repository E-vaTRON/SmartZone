using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlZone.Components.DeviceViewCell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceViewCell : ContentView
    {
        public static readonly BindableProperty DeviceImageUrl = BindableProperty.Create(nameof(DeviceImageUrlString), typeof(string), typeof(DeviceViewCell));

        public string DeviceImageUrlString
        {
            get
            {
                return (string)GetValue(DeviceImageUrl);
            }
            set
            {
                SetValue(DeviceImageUrl, value);
            }
        }
        public DeviceViewCell()
        {
            InitializeComponent();
        }
    }
}