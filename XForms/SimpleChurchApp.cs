﻿using System;

using Xamarin.Forms;

namespace SimpleChurchApp
{
	public class App : Application
	{
		public App ()
		{
			NavigationPage np = new NavigationPage (new SimpleChurchTabbedPage ());
			np.BarBackgroundColor = Color.Gray;
			MainPage = np;


			// The root page of your application
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"
//						}
//					}
//				}
//			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

