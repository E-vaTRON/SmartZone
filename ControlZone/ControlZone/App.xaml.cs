using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("SinkinSans-900XBlack.otf", Alias = "SinkinSans")]
[assembly: ExportFont("KaushanScript-Regular.otf", Alias = "KaushanScript")]
[assembly: ExportFont("BRLNSR.TTF", Alias = "BerlinSR")]
[assembly: ExportFont("Biome-W04-Bold.otf", Alias = "Biome")]
namespace ControlZone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Brush_Experimental", "Shapes_Experimental" });
            MainPage = new SharedTransitionNavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
