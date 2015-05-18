using System;
using UIKit;

namespace SimpleChurchApp.iOS
{
	public class HomeController : UIViewController
	{
		public HomeController ()
		{
			UIView view = new UIView () { BackgroundColor = UIColor.Purple };
			this.View = view;
			this.Title = "Home";
		}
	}
}

