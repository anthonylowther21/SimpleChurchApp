using System;
using UIKit;
using MonoTouch.Dialog;

namespace SimpleChurchApp.iOS
{
	public class SermonsController : DialogViewController
	{
		public SermonsController () : base (UITableViewStyle.Grouped, null, true)
		{
			UIView sectionHeader = new UIView ();
			sectionHeader.Frame = new CoreGraphics.CGRect (0, 0, this.TableView.Frame.Width, 20);
			UILabel label = new UILabel (sectionHeader.Frame) { BackgroundColor = UIColor.Orange };
			sectionHeader.Add (label);
			label.Text = "HEY SECTIONS!";


			var root = new RootElement ("Sermons"){
				new Section (sectionHeader){
					new RootElement ("First level", 0, 0) {
						new Section (null, "This is the first level."){
							new RootElement ("Second level", 0, 0) {
								new Section (null, "This is the second level."){
									new BooleanElement ("Flipflops", false)
								}
							}
						}
					}}
			};

			this.Root = root;

		}
	}
}

