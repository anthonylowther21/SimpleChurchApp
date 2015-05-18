using System;
using UIKit;

namespace SimpleChurchApp.iOS
{
	public class SmallGroupsController : UIViewController
	{
		public SmallGroupsController ()
		{
			UIView view = new UIView () { BackgroundColor = UIColor.Orange };
			this.View = view;
			this.Title = "Small Groups";
		}
	}
}

