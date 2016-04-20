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

			b1.TouchUpInside += delegate
			{
				new UIAlertView("Touch1", "TouchUpInside handled", null, "OK", null).Show();
			};

			b2.TouchUpInside += delegate
			{
				new UIAlertView("Touch1", "TouchUpInside handled", null, "OK", null).Show();
			};
