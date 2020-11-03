using ControlZone.Model;
using ControlZone.Views.DeviceViews;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlZone.Components.DeviceViewCell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceViewCell : ContentView
    {
        public DeviceViewCell()
        {
            InitializeComponent();
        }
        public static readonly BindableProperty DeviceIdProperty = BindableProperty.Create(nameof(DeviceId), typeof(int), typeof(DeviceViewCell), default(int));

        public int DeviceId
        {
            get { return (int)GetValue(DeviceIdProperty); }
            set { SetValue(DeviceIdProperty, value); }
        }
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(DeviceViewCell), default(string));

        public string IconImageSource
        {
            get { return (string)GetValue(IconImageSourceProperty); }
            set { SetValue(IconImageSourceProperty, value); }
        }
        public static readonly BindableProperty ModelProperty = BindableProperty.Create(nameof(Model), typeof(string), typeof(DeviceViewCell), default(string));

        public string Model
        {
            get { return (string)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        public static readonly BindableProperty DeviceColorProperty = BindableProperty.Create(nameof(DeviceColor), typeof(string), typeof(DeviceViewCell), default(string));

        public string DeviceColor
        {
            get { return (string)GetValue(DeviceColorProperty); }
            set { SetValue(DeviceColorProperty, value); }
        }

        public static readonly BindableProperty DeviceTypeProperty = BindableProperty.Create(nameof(DeviceType), typeof(string), typeof(DeviceViewCell), default(string));

        public string DeviceType
        {
            get { return (string)GetValue(DeviceTypeProperty); }
            set { SetValue(DeviceTypeProperty, value); }
        }

        public static readonly BindableProperty OverallProcessProperty = BindableProperty.Create(nameof(OverallProcess), typeof(float), typeof(DeviceViewCell), default(float));

        public float OverallProcess
        {
            get { return (float)GetValue(OverallProcessProperty); }
            set { SetValue(OverallProcessProperty, value); }
        }

        public static readonly BindableProperty PercentageProperty = BindableProperty.Create("Percentage", typeof(double), typeof(DeviceViewCell), 0d, BindingMode.TwoWay);

        public double Percentage
        {
            get { return (double)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }
        public static BindableProperty PowerStatusProperty = BindableProperty.Create(nameof(PowerStatus), typeof(bool), typeof(DeviceViewCell), false, BindingMode.TwoWay);

        public bool PowerStatus
        {
            get { return (bool)GetValue(PowerStatusProperty); }
            set { SetValue(PowerStatusProperty, value); }
        }

        public event EventHandler<EventArgs> DeviceClick;

        private void DeviceLogo_Clicked(object sender, EventArgs e)
        {
            DeviceClick?.Invoke(this, e);
        }
    }
}