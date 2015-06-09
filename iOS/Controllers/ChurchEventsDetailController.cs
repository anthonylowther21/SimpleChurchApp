using System;
using MonoTouch.Dialog;
using UIKit;
using SimpleChurchApp.Shared;

namespace SimpleChurchApp.iOS
{
	public class ChurchEventsDetailController : DialogViewController
	{
		ChurchEvent _churchEvent;

		public ChurchEventsDetailController (ChurchEvent churchEvent = null) : base (UITableViewStyle.Grouped, null, true)
		{
            
			if (churchEvent != null) 
			{
				_churchEvent = churchEvent;
			} 
			else 
			{
                _churchEvent = new ChurchEvent("Save Homeless", new DateTime(2015, 5, 5));
			}


			UIView sectionHeader = new UIView ();
			sectionHeader.Frame = new CoreGraphics.CGRect (0, 0, this.TableView.Frame.Width, 60);
            UILabel label = new UILabel (sectionHeader.Frame) { BackgroundColor = UIColor.Orange, TextAlignment = UITextAlignment.Center };
			sectionHeader.Add (label);
			label.Text = "Sample Header Text";

            RootElement root = new RootElement (_churchEvent.Title);
			Section section = new Section (sectionHeader);
			root.Add (section);


            StyledStringElement eventDetail = new StyledStringElement (_churchEvent.Title);
            section.Add(eventDetail);

            StyledStringElement eventDetailTime = new StyledStringElement (_churchEvent.DateTime.ToShortDateString());
            eventDetailTime.Tapped += () => CalendarEvents.SaveCalendarEvent(_churchEvent);
            section.Add(eventDetailTime);

			this.Root = root;
		}
	}
}

