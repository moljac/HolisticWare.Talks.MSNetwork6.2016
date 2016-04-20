using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace ApplicationLaunch02Code
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }

    [Register("UIViewControllerA")]
    public class UIViewControllerA : UIViewController
    {
        public UIViewControllerA()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            View = new UniversalView();

            base.ViewDidLoad();

			// Perform any additional setup after loading the view

			this.Title = "Viewcontroller A";
			this.View.BackgroundColor = UIColor.Red;

			// Create a new tap gesture
			UITapGestureRecognizer tapGesture = null;

			// Report touch
			Action action = () =>
			{
				UIViewControllerB vcb = new UIViewControllerB();
				this.NavigationController.PushViewController(vcb, true);
			};

			tapGesture = new UITapGestureRecognizer(action);

			// Configure it
			tapGesture.NumberOfTapsRequired = 2;


			this.View.AddGestureRecognizer(tapGesture);

		}
    }
}