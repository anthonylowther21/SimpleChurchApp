using System;

using Xamarin.Forms;

namespace SimpleChurchApp
{
	public class SermonPage : ContentPage
	{
		public SermonPage ()
		{
			Title = "Sermons";

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
							Text = "January 1, 2015",
							Detail = "Big Idea: Love Sushi",
						},

						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "January 8, 2015",
							Detail = "Big Idea: Love M&M's",
						},

						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "January 15, 2015",
							Detail = "Big Idea: Love Reese's",
						},

						new ImageCell
						{
							// Some differences with loading images in initial release.
							ImageSource =
								Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
									ImageSource.FromFile("Images/ide-xamarin-studio.png")),
							Text = "January 15, 2015",
							Detail = "Big Idea: Love Snickers",
						},
					}
				}
			};

			Content = tableView;

		}
	}
}


