using ControlZone.Components.DeviceViewCell;
using ControlZone.Model;
using ControlZone.ViewModels.ViewModelPages.ViewModelDeviceViews;
using Plugin.SharedTransitions;
using System;
using System.Diagnostics;
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
            //ConnectToServerAsync();
        }

        private async void DeviceLogo_Clicked(object sender, System.EventArgs e)
        {
            var SelectedDevice = (DeviceBase)((ImageButton)sender).CommandParameter;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, SelectedDevice.Id.ToString());
            await Navigation.PushAsync(new DeviceDetail(SelectedDevice));
        }

        private void NavigateToDeviceDetail(object sender, EventArgs e)
        {
            var SelectedDevice = (DeviceBase)((ImageButton)sender).CommandParameter;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, SelectedDevice.Id.ToString());
            Navigation.PushAsync(new DeviceDetail(SelectedDevice)).GetAwaiter().GetResult();
        }

        //private async Task ConnectToServerAsync()
        //{
        //    var mqttFactory = new MqttFactory();
        //    var client = mqttFactory.CreateMqttClient();

        //    var options = new MqttClientOptionsBuilder()
        //        .WithTcpServer("localhost", 1883)
        //        .Build();

        //    await client.ConnectAsync(options, CancellationToken.None);

        //    client.UseConnectedHandler(async e =>
        //    {
        //        Debug.WriteLine("### CONNECTED WITH SERVER ###");

        //        // Subscribe to a topic
        //        await client.SubscribeAsync(new TopicFilterBuilder().WithTopic("TrashChannel").Build());

        //        Debug.WriteLine("### SUBSCRIBED ###");
        //    });
        //}
    }
}