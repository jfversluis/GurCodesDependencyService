using Android.Content;
using Android.Runtime;
using Android.Views;
using GurCodesDependencyService.Droid.Implementations;
using GurCodesDependencyService.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationImplementation))]
namespace GurCodesDependencyService.Droid.Implementations
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
			IWindowManager windowManager =
                Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

			var rotation = windowManager.DefaultDisplay.Rotation;
			bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;
			return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}