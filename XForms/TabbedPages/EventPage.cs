using System;

using Xamarin.Forms;

namespace SimpleChurchApp
{
	public class EventPage : ContentPage
	{
		public EventPage ()
		{
			Title = "Events";

			TableView tableView = new TableView
			{
				Intent = TableIntent.Data,
				Root = new TableRoot
				{
					new TableSection
					{
						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "Doing Good Stuff",
							Detail = "We will go to the place with the people and do the things that people need in order to make them feel how they should",

						},

						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "Doing Good Stuff",
							Detail = "We will go to the place with the people and do the things that people need in order to make them feel how they should",
						},

						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "Doing Good Stuff",
							Detail = "We will go to the place with the people and do the things that people need in order to make them feel how they should",
						},

						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "Doing Good Stuff",
							Detail = "We will go to the place with the people and do the things that people need in order to make them feel how they should",
						},
					}
				}
			};

			tableView.Root.

			Content = tableView;
		}
	}
}


