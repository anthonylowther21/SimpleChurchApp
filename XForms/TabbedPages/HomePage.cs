using System;

using Xamarin.Forms;

namespace SimpleChurchApp
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			BackgroundColor = Color.Gray;

			Title = "Home";

			Grid grid = new Grid 
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				},
				RowDefinitions = 
				{
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
				},
				HorizontalOptions = LayoutOptions.FillAndExpand,
			};

			grid.Children.Add(new Label
				{
					Text = "Church Picture",
					Font = Font.BoldSystemFontOfSize(20),
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand, 
					BackgroundColor = Color.Teal,
					XAlign = TextAlignment.Center,
					YAlign = TextAlignment.Center,
				}, 0, 2, 0, 1);

			grid.Children.Add(new Label
				{
					Text = "Sermon Series",
					Font = Font.BoldSystemFontOfSize(20),
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.Purple,
					XAlign = TextAlignment.Center,
					YAlign = TextAlignment.Center,
				}, 0, 2, 1, 2);

			grid.Children.Add(new Label
				{
					Text = "Column 1",
					TextColor = Color.White,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.Green,
				}, 0, 2, 2, 4);

			grid.Children.Add(new Label
				{
					Text = "Column 2",
					TextColor = Color.White,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.Red,
				}, 1, 2, 2, 4);

		

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = grid;
		}
	}
}


