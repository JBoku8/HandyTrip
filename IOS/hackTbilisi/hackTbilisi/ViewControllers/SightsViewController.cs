using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace hackTbilisi
{
	partial class SightsViewController : UITableViewController
	{
		private Sight _selectedSight;

		public SightsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var source = new SightSource (Globals.Sights);
			source.SightSelected = delegate(Sight s) {
				_selectedSight =s;

				this.PerformSegue("sightDetail",this);
			};

			this.TableView.Source = source;
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "sightDetail") {

				var currViewController = segue.DestinationViewController as DetailSightViewController;
				currViewController.Sight = _selectedSight;

			}
		}
	}
}
