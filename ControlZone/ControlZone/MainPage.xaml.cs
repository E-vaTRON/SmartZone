using ControlZone.ViewModels.ViewModelPages;
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
    }
}
