using ControlZone.Model;
using Plugin.SharedTransitions;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
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
            if (Device.RuntimePlatform == Device.iOS)
            {
                //NavigationPage.SetHasNavigationBar(this, true);
            }
            Task.Run(AnimateBackground);
        }

        protected override async void OnAppearing()
        {
            await TopLabel1.TranslateTo(0, 0, 1300, Easing.SpringOut);
            await TopLabel2.TranslateTo(0, 0, 500, Easing.SpringOut);
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