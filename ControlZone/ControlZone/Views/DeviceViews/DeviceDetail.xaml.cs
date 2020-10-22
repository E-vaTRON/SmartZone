using ControlZone.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlZone.Views.DeviceViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDetail : ContentPage
    {
        private DeviceBase Device;
        public DeviceDetail(DeviceBase device)
        {
            InitializeComponent();
            Device = device;
        }
        protected override async void OnAppearing()
        {
            await ViewInitialize(Device);
        }
        private async Task ViewInitialize(DeviceBase device)
        {
            DeviceLogo.Source = device.IconImageSource;
        }
    }
}