using ControlZone.Model;
using ControlZone.Model.TTDevices;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
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
        private float amount;
        public float SelectedAmount
        {
            get { return amount; }
            set
            {
                amount = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<DeviceBase> GetDevices()
        {
            return new ObservableCollection<DeviceBase>
            {
                new CommandCenter {Id = 1, Model = "Command Center 1.0", DeviceType = 0, IconImageSource = "CC1.png", Color = "#45e969", OverallProcess = 0.3f, PowerStatus = true, CPUPercentage = 40.0f },
                new TC {Id = 2, Model = "TC 1.1", DeviceType = 1, IconImageSource = "TC1.png", Color = "#44b1ce", OverallProcess = 0.7f, PowerStatus = true, CurrentCapacity = 80.0f },
                new TC {Id = 3, Model = "Light 1.1", DeviceType = 2, IconImageSource = "Light.png", Color = "#fdf17c", OverallProcess = 0.5f, PowerStatus = false }
            };
        }

        public ViewModelDeviceList()
        {
            Devices = GetDevices();
        }
    }
}
