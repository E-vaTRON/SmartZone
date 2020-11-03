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
        private NavigationPage navigationPage;
        public DeviceDetail(DeviceBase device)
        {
            InitializeComponent();
            Device = device;
            navigationPage = Application.Current.MainPage as NavigationPage;
        }
        protected override async void OnAppearing()
        {
            await ViewInitialize(Device);
        }
        private async Task ViewInitialize(DeviceBase device)
        {
            DeviceLogo.Source = device.IconImageSource;
            ProgressRingDevice.RingProgressColor = Color.FromHex(device.Color);
            navigationPage.BarBackgroundColor = Color.FromHex(device.Color);
            PowerStatusSwitch.IsToggled = device.PowerStatus;
            ProgressRingDevice.AnimatedProgress = device.OverallProcess;
        }
    }
}