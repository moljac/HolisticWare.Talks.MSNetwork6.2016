﻿using System;

using UIKit;

namespace ApplicationLaunch02SingleViewStoryboard
{
	public partial class ViewControllerA : UIViewController
	{
		public ViewControllerA() : base("ViewControllerA", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


