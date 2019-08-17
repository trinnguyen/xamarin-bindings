using System;
using Foundation;
using UIKit;
using Xamarin.Toast;
using CoreGraphics;

namespace SampleToast
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            DemoToast();
        }

        private void DemoToast()
        {
            // basic usage
            View.MakeToast("This is a piece of toast.");

            // toast with a specific duration and position
            View.MakeToast("This is a piece of toast with a specific duration and position", 
                                3f,
                                ToastConstants.CSToastPositionTop);
            // toast with all possible options
            View.MakeToast("This is a piece of toast with a title & image",
                                3f,
                                NSValue.FromCGPoint(new CGPoint(110, 110)),
                                "Toast Title",
                                UIImage.FromBundle("toast.png"),
                                null,
                                (bool didTap) => System.Diagnostics.Debug.WriteLine($"Did tap: {didTap}"));

            // display toast with an activity spinner
            View.MakeToastActivity(ToastConstants.CSToastPositionCenter);

            // display any view as toast
            //View.ShowToast(customView);
        }
    }
}
