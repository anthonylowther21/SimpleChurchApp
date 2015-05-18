using System;
using UIKit;

namespace SimpleChurchApp.iOS
{
	public class AboutController : UIViewController
	{
		public AboutController ()
		{
			UIView view = new UIView () { BackgroundColor = UIColor.Red };
			this.View = view;
			this.Title = "About";
		}
	}
}

