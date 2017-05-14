using GurCodesDependencyService.Interfaces;
using Xamarin.Forms;

namespace GurCodesDependencyService
{
    public partial class GurCodesDependencyServicePage : ContentPage
    {
        public GurCodesDependencyServicePage()
        {
            InitializeComponent();

            OrientationLabel.Text = 
                DependencyService.Get<IDeviceOrientation>().GetOrientation().ToString();
        }
    }
}
