using ControlZone.Model;
using ControlZone.ViewModels.ViewModelPages.ViewModelDeviceViews;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlZone.Views.DeviceViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceList : ContentPage
    {
        public DeviceList()
        {
            InitializeComponent();
            BindingContext = new ViewModelDeviceList();
        }

        private async void DeviceLogo_Clicked(object sender, System.EventArgs e)
        {
            var SelectedDevice = (DeviceBase)((ImageButton)sender).CommandParameter;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, SelectedDevice.Id.ToString());
            await Navigation.PushAsync(new DeviceDetail(SelectedDevice));
        }
    }
}