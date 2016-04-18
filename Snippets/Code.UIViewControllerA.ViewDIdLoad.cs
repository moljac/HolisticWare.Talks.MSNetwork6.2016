			this.Title = "Viewcontroller A";
			this.View.BackgroundColor = UIColor.Red;

			// Create a new tap gesture
			UITapGestureRecognizer tapGesture = null;

			// Report touch
			Action action = () => 
			{
				var vcb = new UIViewControllerB();
				this.NavigationController.PushViewController(vcb, true);
			};

			tapGesture = new UITapGestureRecognizer(action);

			// Configure it
			tapGesture.NumberOfTapsRequired = 2;


			this.View.AddGestureRecognizer (tapGesture);

