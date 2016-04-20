            // Fnishedlaunching

			this.Window = new UIWindow();
			this.Window.Frame = UIScreen.MainScreen.Bounds;


			ViewControllerA vca = new ViewControllerA ();
			UINavigationController rnc = new UINavigationController(vca);

			this.Window.RootViewController = rnc;
