using System;

using Xamarin.Forms;

namespace SimpleChurchApp
{
	public class SmallGroupPage : ContentPage
	{
		public SmallGroupPage ()
		{
			Title = "Small Groups";
			Content = new Label () {
				Text = "Small Groups",
				HeightRequest = 100f,
				VerticalOptions = LayoutOptions.Center
			};
		}
	}
}


