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
            //AnimatedText(Percentage);
        }
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(DeviceViewCell), default(string));

        public string IconImageSource
        {
            get
            {
                return (string)GetValue(IconImageSourceProperty);
            }
            set
            {
                SetValue(IconImageSourceProperty, value);
            }
        }
        public static readonly BindableProperty ModelProperty = BindableProperty.Create(nameof(Model), typeof(string), typeof(DeviceViewCell), default(string));

        public string Model
        {
            get
            {
                return (string)GetValue(ModelProperty);
            }
            set
            {
                SetValue(ModelProperty, value);
            }
        }

        public static BindableProperty PercentageProperty = BindableProperty.Create("Percentage", typeof(double), typeof(DeviceViewCell), 0d, BindingMode.TwoWay);

        public double Percentage
        {
            get { return (double)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }
        public static BindableProperty PowerStatusProperty = BindableProperty.Create(nameof(PowerStatus), typeof(bool), typeof(DeviceViewCell), false, BindingMode.TwoWay);

        public bool PowerStatus
        {
            get
            {
                return (bool)GetValue(PowerStatusProperty);
            }
            set
            {
                SetValue(PowerStatusProperty, value);
            }
        }

        //private void AnimatedText(float amount)
        //{
        //    var stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    Device.StartTimer(TimeSpan.FromSeconds(1 / 100f), () =>
        //    {
        //        double t = stopwatch.Elapsed.TotalMilliseconds % 500 / 500;

        //        Percentage = Math.Min((float)amount, (float)(10 * t) + Percentage);

        //        if (Percentage >= (float)amount)
        //        {
        //            stopwatch.Stop();
        //            return false;
        //        }

        //        return true;
        //    });
        //}
    }
}