using System;
using ScanditSDK;
using Foundation;
using System.Linq;

namespace hackTbilisi
{
	public class ScannerDelegate : SIOverlayControllerDelegate
	{
		public Action SouvenierAdded{ get; set; }
		
		public override void DidScanBarcode (SIOverlayController overlayController, NSDictionary barcode) {
			Console.WriteLine ("barcode scanned: {0}, '{1}'", barcode["symbology"], barcode["barcode"]);

			if (!Globals.MyFavorites.Contains (Globals.Souveniers.Where (o => o.Id == barcode ["barcode"].ToString()).SingleOrDefault ()) &&Globals.Souveniers.Contains(Globals.Souveniers.Where(o=>o.Id==barcode["barcode"].ToString()).SingleOrDefault())) {

				if(Globals.Cart.Exists(o=>o.Id==barcode["barcode"].ToString()))
					return;

				Globals.MyFavorites.Add (Globals.Souveniers.Where (o => o.Id == barcode ["barcode"].ToString()).SingleOrDefault ());
				if (SouvenierAdded != null)
						SouvenierAdded.Invoke ();
			}

			overlayController.DismissViewController (true, null);
		}

		public override void DidCancel (SIOverlayController overlayController, NSDictionary status) {
			// perform actions after cancel was pressed
		}

		public override void DidManualSearch (SIOverlayController overlayController, string text) {
			// perform actions after search was used
		}
	}
}

