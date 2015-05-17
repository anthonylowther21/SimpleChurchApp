using System;

using Xamarin.Forms;

namespace SimpleChurchApp
{
	public class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			Title = "About";
			Content = new Label () {
				Text = "About",
				HeightRequest = 100f,
				VerticalOptions = LayoutOptions.Center
			};
		}
	}
}


