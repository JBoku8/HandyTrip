using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace hackTbilisi
{
	partial class MarketViewController : UITableViewController
	{
		public MarketViewController (IntPtr handle) : base (handle)
		{
		}

		private Souvenir _selectedSouvenir;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Globals.SouvenirCompanies [0].Souveniers = new List<Souvenir> ();
			Globals.SouvenirCompanies [1].Souveniers = new List<Souvenir> ();

			Globals.SecSouveniers.AddRange (Globals.Souveniers);
			Globals.SouvenirCompanies [0].Souveniers.AddRange (Globals.Souveniers);
			Globals.SouvenirCompanies [1].Souveniers.AddRange (Globals.SecSouveniers);

			var marketSource = new MarketSource (Globals.SouvenirCompanies, this);
			this.TableView.Source = marketSource;

			marketSource.SouvenirClicked = delegate(Souvenir s) {

				_selectedSouvenir = s;
				this.PerformSegue("detailSegue",this);
			};
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "detailSegue") {

				var viewController = segue.DestinationViewController as DetailsViewController;
				viewController.Souvenir = _selectedSouvenir;

			}
		}
	}
}
