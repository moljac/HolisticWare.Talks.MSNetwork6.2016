# MSNetwork6 Xamarin.iOS Intro

0.	Intro
	no slides
	1.	name
	2.	position
	3.	agenda
1.	Demo 01
	5 minutes
	1.	Windows Acer
	2.	Mac towards audience
	3.	Visual Studio Demo.sln
	4.	Create iOS App projects
		1.	Blank:
			ApplicationLaunch01Empty
		2.	Blank:
			AppLaunchAndUIDefinition02Code
	5.	Launch
2.	Presentation
	25 minutes
	1.	switch to Mac
3.	Demo 02
	1.	Create iOS App Projects
		AppLaunchAndUIDefinition02Storyboard
		1.	Designer
			1.	Add UINavigationViewConotroller
			2.	Delete old/orginal UIViewController
			3.	Iki: Conversion??
			3.	Screens - add 2 UIViewControllers
				1.	delete *.xib
				2.	change View Controller ctors
					1.	UIViewController from code
						ctor(IntPtr handle) : base(handle)
					2.	UIViewController from XIB
						ctor() : base("xib_basename", null)
					