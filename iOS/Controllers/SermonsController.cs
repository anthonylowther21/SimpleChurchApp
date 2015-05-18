using System;
using UIKit;

namespace SimpleChurchApp.iOS
{
	public class SermonsController : UIViewController
	{
		public SermonsController ()
		{
			UIView view = new UIView () { BackgroundColor = UIColor.Green };
			this.View = view;
			this.Title = "Sermons";
		}
	}
}

