using ControlZone.ViewModels.ViewModelPages;
using ControlZone.Views.DeviceViews;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace ControlZone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModelMainPage();
        }
        private async void CommandButtonClick(object sender, System.EventArgs e)
        {
            var selectedCommand = (Tool)((Button)sender).CommandParameter;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, selectedCommand.image.ToString());
            switch (selectedCommand.image)
            {
                case "UtilitiesO":
                    await Navigation.PushAsync(new DeviceList());
                    break;

                case "JobO":
                    await Navigation.PushAsync(new TaskList());
                    break;

                case "FoodO":
                    await Navigation.PushAsync(new MenuList());
                    break;

                case "UserO":
                    await Navigation.PushAsync(new EmployeeList());
                    break;
            }
        }
    }
}
