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
            Task.Run(AnimateBackground);
            BindingContext = new ViewModelMainPage();
        }
        private async void CommandButtonClick(object sender, System.EventArgs e)
        {
            var selectedCommand = (Tool)((Button)sender).CommandParameter;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, selectedCommand.image.ToString());
            switch (selectedCommand.image)
            {
                case "Devices":
                    await Navigation.PushAsync(new DeviceList());
                    break;

                case "JobO":
                    await Navigation.PushAsync(new TaskList());
                    break;

                case "FoodO":
                    await Navigation.PushAsync(new MenuList());
                    break;

                case "Employee":
                    await Navigation.PushAsync(new EmployeeList());
                    break;
            }
        }
        private async void AnimateBackground()
        {
            Action<double> forward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;

            while (true)
            {
                bdGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 1000, easing: Easing.SinIn);
                await Task.Delay(1000);
            }
        }
    }
}
