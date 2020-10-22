using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ControlZone.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public HttpClient httpClient = new HttpClient();

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { OnPropertyChanged(); }
        }

        private int _itemTreshold;
        public int ItemTreshold
        {
            get { return _itemTreshold; }
            set { OnPropertyChanged(); }
        }
        public ICommand RefreshItemsCommand { get; set; }
        public ICommand IncreamentLoadCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
