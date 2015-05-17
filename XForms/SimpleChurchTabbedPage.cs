using System;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace SimpleChurchApp
{
	public class SimpleChurchTabbedPage : ExtendedTabbedPage
	{
		public SimpleChurchTabbedPage ()
		{
//			this.BarTintColor = Xamarin.Forms.Color.Pink;
//			this.TintColor = Xamarin.Forms.Color.Pink;
//			this.SwipeEnabled = true;
//			this.OnSwipeRight += (object sender, EventArgs e) => {
//				TestFunction (true);
//			};
//
//			this.OnSwipeLeft += (object sender, EventArgs e) => {
//				TestFunction (false);
//			};
			this.Title = "Simple Church";
			this.Children.Add (new HomePage ());
			this.Children.Add (new SermonPage ());
			this.Children.Add (new EventPage ());
			this.Children.Add (new SmallGroupPage ());
			this.Children.Add (new AboutPage ());

			this.Opacity = 100;
			this.Badges.Add ("1");
		}

		private void TestFunction(bool isRightSwipe)
		{
			bool something = true;
		}
	}
}


