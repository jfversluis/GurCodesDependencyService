using System;
using GurCodesDependencyService.Interfaces;
using GurCodesDependencyService.iOS.Implementations;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationImplementation))]
namespace GurCodesDependencyService.iOS.Implementations
{
    public class DeviceOrientationImplementation : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
			var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;

			bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait
				|| currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

			return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}