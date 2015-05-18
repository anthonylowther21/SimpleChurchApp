using System;
using UIKit;
using MonoTouch.Dialog;

namespace SimpleChurchApp.iOS
{
	public class EventsController : DialogViewController
	{
		public EventsController () : base (UITableViewStyle.Plain, new RootElement("Events"), true)
		{
			UIView sectionHeader = new UIView ();
			sectionHeader.Frame = new CoreGraphics.CGRect (0, 0, this.TableView.Frame.Width, 20);
			UILabel label = new UILabel (sectionHeader.Frame) { BackgroundColor = UIColor.Orange };
			sectionHeader.Add (label);
			label.Text = "HEY SECTIONS!";
			Section section = new Section (sectionHeader);
			this.Title = "Events";

			StyledStringElement stringelement = new StyledStringElement ("HELLO WORLD!");
			stringelement.Accessory = UITableViewCellAccessory.DisclosureIndicator;

			for (int i = 0; i < 25; i++)
				section.Add (stringelement);

			Root.Add (section);
		}
	}
}

