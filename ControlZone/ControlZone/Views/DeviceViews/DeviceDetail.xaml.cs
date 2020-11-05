using ControlZone.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlZone.Views.DeviceViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDetail : ContentPage, INotifyPropertyChanged
    {
        private DeviceBase deviceprop;
        public DeviceBase Device { get { return deviceprop;  } set { deviceprop = value; OnPropertyChanged(); } }
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
            navigationPage.BarBackgroundColor = Color.FromHex(device.Color);
            DeviceLogo.Source = device.IconImageSource;
        }
    }
}