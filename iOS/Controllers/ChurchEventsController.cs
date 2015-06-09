using System;
using UIKit;
using MonoTouch.Dialog;

namespace SimpleChurchApp.iOS
{
	public class ChurchEventsController : DialogViewController
	{
		public ChurchEventsController () : base (UITableViewStyle.Grouped, null, true)
		{
			UIView sectionHeader = new UIView ();
			sectionHeader.Frame = new CoreGraphics.CGRect (0, 0, this.TableView.Frame.Width, 60);
			UILabel label = new UILabel (sectionHeader.Frame) { BackgroundColor = UIColor.Orange };
			sectionHeader.Add (label);
			label.Text = "Event Listing";

			RootElement root = new RootElement ("Events");
			Section section = new Section (sectionHeader);
			root.Add (section);

			for (int i = 1; i < 15; i++) 
			{
				StyledStringElement eventDetail = new StyledStringElement ("Event " + i.ToString());
                eventDetail.Tapped += () => this.NavigationController.PushViewController (new ChurchEventsDetailController (), true);
				eventDetail.Accessory = UITableViewCellAccessory.DisclosureIndicator;

				section.Add ( eventDetail );
			}

			this.Root = root;

		}
	}
}

