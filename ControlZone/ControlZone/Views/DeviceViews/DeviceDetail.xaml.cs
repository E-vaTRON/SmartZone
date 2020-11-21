using ControlZone.Model;
using Microcharts;
using SkiaSharp;
using System;
using System.ComponentModel;
using System.Diagnostics;
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
        public Chart LineChartSample => new LineChart()
        {
            Entries = new[]
            {
                new ChartEntry(100)
                {
                    Color = SKColor.Parse("#cb2d3e"),
                    TextColor = SKColor.Parse("#cb2d3e"),
                    ValueLabelColor = SKColor.Parse("#cb2d3e"),
                    Label = "Thứ 2",
                    ValueLabel = "100%"
                },
                new ChartEntry(75)
                {
                    Color = SKColor.Parse("#d76b26"),
                    TextColor = SKColor.Parse("#d76b26"),
                    ValueLabelColor = SKColor.Parse("#d76b26"),
                    Label = "Thứ 3",
                    ValueLabel = "75%"
                },
                new ChartEntry(25)
                {
                    Color = SKColor.Parse("#ffd200"),
                    TextColor = SKColor.Parse("#ffd200"),
                    ValueLabelColor = SKColor.Parse("#ffd200"),
                    Label = "Thứ 4",
                    ValueLabel = "25%"
                },
                new ChartEntry(5)
                {
                    Color = SKColor.Parse("#159957"),
                    TextColor = SKColor.Parse("#159957"),
                    ValueLabelColor = SKColor.Parse("#159957"),
                    Label = "Thứ 5",
                    ValueLabel = "5%"
                },
                new ChartEntry(40)
                {
                    Color = SKColor.Parse("#1cb5e0"),
                    TextColor = SKColor.Parse("#1cb5e0"),
                    ValueLabelColor = SKColor.Parse("#1cb5e0"),
                    Label = "Thứ 6",
                    ValueLabel = "40%"
                },
                new ChartEntry(28)
                {
                    Color = SKColor.Parse("#155799"),
                    TextColor = SKColor.Parse("#155799"),
                    ValueLabelColor = SKColor.Parse("#155799"),
                    Label = "Thứ 7",
                    ValueLabel = "28%"
                },
                new ChartEntry(62)
                {
                    Color = SKColor.Parse("#ef32d9"),
                    TextColor = SKColor.Parse("#ef32d9"),
                    ValueLabelColor = SKColor.Parse("#ef32d9"),
                    Label = "CN",
                    ValueLabel = "62%"
                },
            },
            BackgroundColor = SKColors.Transparent,
            AnimationDuration = new TimeSpan(0,0,6),
            AnimationProgress = 6000,
            IsAnimated = true,
            LineMode = LineMode.Straight,
            LabelTextSize = 25,
            LabelColor = SKColors.Black,
            LabelOrientation = Orientation.Horizontal,
        };

        private NavigationPage navigationPage;
        public DeviceDetail(DeviceBase device)
        {
            InitializeComponent();
            Device = device;
            navigationPage = Application.Current.MainPage as NavigationPage;
            Task.Run(AnimateBackground);
        }
        protected override async void OnAppearing()
        {
            await ViewInitialize(Device);
        }
        private async Task ViewInitialize(DeviceBase device)
        {
            var background = new LinearGradientBrush
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(0, 1),
                GradientStops = new GradientStopCollection
                {
                    new GradientStop { Color = Color.FromHex(Device.GradientColor1), Offset = 0.5f },
                    new GradientStop { Color = Color.FromHex(Device.GradientColor2), Offset = 0.7f }
                }
            };
            bdGradient.Background = background;
            navigationPage.BarBackgroundColor = Color.FromHex(device.Color);
            DeviceLogo.Source = device.IconImageSource;
            PowerUsageChart.Chart = LineChartSample;
            await SecondFirstRowCell.TranslateTo(0, 0, 700, Easing.CubicOut);
            await SecondSecondRowCell.TranslateTo(0, 0, 700, Easing.CubicOut);
            await ThirdRowCell.TranslateTo(0, 0, 700, Easing.CubicOut);
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

        private async void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Debug.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
            if(e.ScrollY > 10) await FourthRowCell.TranslateTo(0, 0, 700, Easing.CubicOut);
            else await FourthRowCell.TranslateTo(0, 500, 700, Easing.CubicIn);
        }
    }
}