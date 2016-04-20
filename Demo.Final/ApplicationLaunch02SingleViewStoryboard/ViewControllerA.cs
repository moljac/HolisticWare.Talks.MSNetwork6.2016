using System;

using UIKit;

namespace ApplicationLaunch02SingleViewStoryboard
{
	public partial class ViewControllerA : UIViewController
	{
		public ViewControllerA(IntPtr handle) : base(handle)
		{
		}

		UIButton button1 = null;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


			UIButton b1 = UIButton.FromType(UIButtonType.System);
			b1.SetTitle("DotNet", UIControlState.Normal);
			b1.Frame = new CoreGraphics.CGRect(20, 60, 60, 44);

			UIButton b2 = UIButton.FromType(UIButtonType.System);
			b2.SetTitle("iOS API", UIControlState.Normal);
			b2.Frame = new CoreGraphics.CGRect(320, 60, 60, 44);
		
			UIWebView webView = new UIWebView(new CoreGraphics.CGRect(20, 100, 400, 620));
			View.AddSubview(webView);			
			var url = "https://xamarin.com";
			webView.LoadRequest(new Foundation.NSUrlRequest(new Foundation.NSUrl(url)));

			b1.TouchUpInside += async delegate
			{
				using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
				{
					string uri = "http://msnetwork.ba";

					// ... Read the string.
					string result = await client.GetStringAsync(uri);

					webView.LoadHtmlString
								(
									result,
									new Foundation.NSUrl(".", true)
								);
				}
			};

			b2.TouchUpInside += delegate
			{
				string uri = "http://apple.com";

				using (Foundation.NSUrl nsurl = new Foundation.NSUrl(uri))
				{
					var request = new Foundation.NSUrlRequest(nsurl);
					webView.LoadRequest(request);
				}
			};

			View.Add(b1);
			View.AddSubview(b2);
			View.AddSubviews(webView);

			return;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


