
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
