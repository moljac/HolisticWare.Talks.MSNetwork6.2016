            // Fnishedlaunching

			this.Window = new UIWindow();
			this.Window.Frame = UIScreen.MainScreen.Bounds;

			var viewcontrollerA = new ViewControllerA ();
			var rootNavigationController = new UINavigationController(viewcontrollerA);

			this.Window.RootViewController = rootNavigationController;
