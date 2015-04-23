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

//			Grid grid = new Grid
//			{
//				VerticalOptions = LayoutOptions.FillAndExpand,
//				ColumnDefinitions = 
//				{
//					new ColumnDefinition { Width = GridLength.Auto },
//					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
//					new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
//				},
//				RowDefinitions = 
//				{
//					new RowDefinition { Height = GridLength.Auto },
//					new RowDefinition { Height = GridLength.Auto },
//					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
//					new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
//				},
//				};
//
//			grid.Children.Add(new Label
//				{
//					Text = "Grid",
//					Font = Font.BoldSystemFontOfSize(50),
//					HorizontalOptions = LayoutOptions.Center
//				}, 0, 3, 0, 1);
//
//			grid.Children.Add(new Label
//				{
//					Text = "Autosized cell",
//					TextColor = Color.White,
//					BackgroundColor = Color.Blue
//				}, 0, 1);
//
//			grid.Children.Add(new BoxView
//				{
//					Color = Color.Silver,
//					HeightRequest = 0
//				}, 1, 1);
//
//			grid.Children.Add(new BoxView
//				{
//					Color = Color.Teal
//				}, 0, 2);
//
//			grid.Children.Add(new Label
//				{
//					Text = "Leftover space",
//					TextColor = Color.Purple,
//					BackgroundColor = Color.Aqua,
//					XAlign = TextAlignment.Center,
//					YAlign = TextAlignment.Center,
//				}, 1, 2);
//
//			grid.Children.Add(new Label
//				{
//					Text = "Span two rows (or more if you want)",
//					TextColor = Color.Yellow,
//					BackgroundColor = Color.Navy,
//					XAlign = TextAlignment.Center,
//					YAlign = TextAlignment.Center
//				}, 2, 3, 1, 3);
//
//			grid.Children.Add(new Label
//				{
//					Text = "Span 2 columns",
//					TextColor = Color.Blue,
//					BackgroundColor = Color.Yellow,
//					XAlign = TextAlignment.Center,
//					YAlign = TextAlignment.Center
//				}, 0, 2, 3, 4);
//
//			grid.Children.Add(new Label
//				{
//					Text = "Fixed 100x100",
//					TextColor = Color.Aqua,
//					BackgroundColor = Color.Red,
//					XAlign = TextAlignment.Center,
//					YAlign = TextAlignment.Center
//				}, 2, 3);


			Grid grid = new Grid {
				VerticalOptions = LayoutOptions.FillAndExpand,
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				},
				RowDefinitions = {
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



//			StackLayout stackLayout = new StackLayout ();
//
//			stackLayout.Children.Add (new Label () { Text = "Church Picture", HeightRequest = 150, YAlign = TextAlignment.Center, XAlign = TextAlignment.Center, BackgroundColor = Color.Silver, FontSize = 20 });
//			stackLayout.Children.Add (new Label () { Text = "Sermon Series", HeightRequest = 150, YAlign = TextAlignment.Center, XAlign = TextAlignment.Center, BackgroundColor = Color.Silver, FontSize = 20 });

//			this.Content = grid;

			//stackLayout.Children.Add (new Label () { Text = "Church Picture", FontSize = 20 });

//			Label cpLabel = new Label ();
//			cpLabel.Text = "Sermon Series";
//			cpLabel.HeightRequest = 100f;
//			cpLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
//			cpLabel.XAlign = TextAlignment.Center;
//
//			Label cpLabel2 = new Label ();
//			cpLabel2.Text = "Mission Statement";
//			cpLabel2.HeightRequest = 100f;
//			cpLabel2.VerticalOptions = LayoutOptions.CenterAndExpand;
//			cpLabel2.XAlign = TextAlignment.Center;
//
//			Label cpLabel3 = new Label ();
//			cpLabel3.Text = "Church Pictures";
//			cpLabel3.HeightRequest = 100f;
//			cpLabel3.VerticalOptions = LayoutOptions.CenterAndExpand;
//			cpLabel3.XAlign = TextAlignment.Center;
//
//			ContentPage contentPage = new ContentPage ();
//			contentPage.Content = cpLabel;
//
//			ContentPage contentPage2 = new ContentPage ();
//			contentPage2.Content = cpLabel2;
//
//			ContentPage contentPage3 = new ContentPage ();
//			contentPage3.Content = cpLabel3;

//			CarouselPage cp = new CarouselPage ();
//			cp.Children.Add (contentPage);
//			cp.Children.Add (contentPage2);
//			cp.Children.Add (contentPage3);
				

//			this.Children.Add (contentPage);
//			this.Children.Add (contentPage2);
//			this.Children.Add (contentPage3);
		}
	}
}


