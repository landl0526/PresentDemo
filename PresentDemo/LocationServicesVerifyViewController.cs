using Foundation;
using System;
using UIKit;

namespace PresentDemo
{
    public partial class LocationServicesVerifyViewController : UIViewController
    {
        public LocationServicesVerifyViewController (IntPtr handle) : base (handle)
        {
        }

        partial void EnableBtnClick(UIKit.UIButton sender)
        {
            NSString settingsString = UIApplication.OpenSettingsUrlString;
            NSUrl url = new NSUrl(settingsString);
            UIApplication.SharedApplication.OpenUrl(url);
        }
    }
}