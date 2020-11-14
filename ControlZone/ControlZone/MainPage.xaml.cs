using ControlZone.ViewModels.ViewModelPages;
using ControlZone.Views.DeviceViews;
using Plugin.SharedTransitions;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;

namespace ControlZone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, true);
                bdGradient.Scale = 1;
            }
            else if(Device.RuntimePlatform == Device.Android)
            {
                Task.Run(AnimateBackground);
            }
            BindingContext = new ViewModelMainPage();
        }
        protected override async void OnAppearing()
        {
        }
        private async void DeviceListClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeviceList());
        }
        private async void AnimateBackground()
        {
            Action<double> forward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;


            while (true)
            {
                bdGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 1000, easing: Easing.SinIn);
                await Task.Delay(3000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 1000, easing: Easing.SinIn);
                await Task.Delay(3000);
            }
        }
    }
}
