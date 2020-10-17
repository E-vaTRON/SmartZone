using ControlZone.ViewModels.ViewModelPages;
using ControlZone.Views;
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
        private async void DeviceList_Click(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DeviceList());
        }
    }
}
