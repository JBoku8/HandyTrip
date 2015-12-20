using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreGraphics;

namespace hackTbilisi
{
	partial class FavTableViewCountroller : UITableViewController
	{
		private ScannerDelegate _scannerDelegate;
		private ScanditSDK.SIBarcodePicker _scannerPicker;

		public FavTableViewCountroller (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;

			_scannerPicker = new ScanditSDK.SIBarcodePicker ("fXfplKzOarBwI/0SFOUap8maaChn/TNsaUtwgy0RjPQ");
			_scannerDelegate = new ScannerDelegate ();
			_scannerPicker.OverlayController.Delegate = _scannerDelegate;

			this.TableView.TableFooterView = new UIView (CGRect.Empty);

			_scannerDelegate.SouvenierAdded = delegate {

				this.TableView.Source = new SouvenirSource(Globals.MyFavorites,this);
			};
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			UIBarButtonItem addBarBtn = new UIBarButtonItem ("Add", UIBarButtonItemStyle.Plain, addBtn_clicked);
			addBarBtn.TintColor = UIColor.White;

			this.TabBarController.NavigationItem.RightBarButtonItem = addBarBtn;

		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			this.TabBarController.NavigationItem.RightBarButtonItem = null;
		}
			

		private void addBtn_clicked(object sender,EventArgs e){

			Console.WriteLine (UIScreen.MainScreen.Bounds.GetMaxY()+"**********");
			UIToolbar toolbar = new UIToolbar (new CoreGraphics.CGRect (0, 520, UIScreen.MainScreen.Bounds.Width, (nfloat)50));
			Console.WriteLine (UIScreen.MainScreen.Bounds.GetMaxY());


			UIButton cancelBtn = new UIButton (UIButtonType.Custom);
			cancelBtn.Frame = new CoreGraphics.CGRect (0, 10, 100, 40);
			cancelBtn.SetTitle ("Cancel", UIControlState.Normal);
			cancelBtn.SetTitleColor (UIColor.Orange, UIControlState.Normal);

			cancelBtn.TouchUpInside += delegate {

				_scannerPicker.DismissViewController(true,null);
			};
			toolbar.Add (cancelBtn);

			_scannerPicker.Add (toolbar);

			this.PresentViewController (_scannerPicker, true, null);
			_scannerPicker.StartScanning ();
		}
	}
}
