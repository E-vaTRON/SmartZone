using ControlZone.Model;
using ControlZone.Model.TTDevices;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ControlZone.ViewModels.ViewModelPages.ViewModelDeviceViews
{
    public class ViewModelDeviceList : ViewModelBase
    {
        private ObservableCollection<DeviceBase> devices;
        public ObservableCollection<DeviceBase> Devices
        {
            get { return devices; }
            set
            {
                devices = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<DeviceBase> GetDevices()
        {
            return new ObservableCollection<DeviceBase>
            {
                new CommandCenter {Id = 1, Model = "Command Center 1.0", DeviceType = 0, IconImageSource = "CC1.png", 
                                   Color = "#45e969", GradientColor1 = "#ECCB58", GradientColor2 = "#96C93D",
                                   OverallProcess = 0.3f, PowerStatus = true, CPUPercentage = 40.0f },
                new TC {Id = 2, Model = "TC 1.1", DeviceType = 1, IconImageSource = "TC1.png", 
                    Color = "#44b1ce", GradientColor1 = "#90cff3", GradientColor2 = "#7ae2be",
                    OverallProcess = 0.7f, PowerStatus = true, CurrentCapacity = 80.0f },
                new TLight {Id = 3, Model = "Light 1.1", DeviceType = 2, IconImageSource = "Light.png", 
                    Color = "#fdf17c", GradientColor1 = "#F2994A", GradientColor2 = "#F2C94C",
                    OverallProcess = 0.5f, PowerStatus = false },
                new TLight {Id = 4, Model = "Light 1.1", DeviceType = 2, IconImageSource = "Light.png",
                    Color = "#fdf17c", GradientColor1 = "#F2994A", GradientColor2 = "#F2C94C",
                    OverallProcess = 1.0f, PowerStatus = true },
            };
        }
        public static BindableProperty AnimatedProgressProperty =
                      BindableProperty.CreateAttached("AnimatedProgress",
                                   typeof(double),
                                   typeof(ProgressBar),
                                   0.0d,
                                   BindingMode.OneWay,
                                   propertyChanged: (b, o, n) =>
                                   ProgressBarProgressChanged((ProgressBar)b, (double)n));

        private static void ProgressBarProgressChanged(ProgressBar progressBar, double progress)
        {
            ViewExtensions.CancelAnimations(progressBar);
            progressBar.ProgressTo((double)progress, 800, Easing.SinOut);
        }

        public ViewModelDeviceList()
        {
            Devices = GetDevices();
        }

    }
}
