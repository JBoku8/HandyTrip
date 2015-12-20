using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace hackTbilisi
{
	partial class CartViewController : UITableViewController
	{
		public CartViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			CartSource source = new CartSource (Globals.Cart,this);
			this.TableView.Source = source;
			this.TableView.ReloadData ();

			UIBarButtonItem editBtn = new UIBarButtonItem ("Edit", UIBarButtonItemStyle.Plain, editBtn_click);
			editBtn.TintColor = UIColor.White;

			this.TabBarController.NavigationItem.RightBarButtonItem = editBtn;

			if (Globals.Cart.Count != 0) {

				UIBarButtonItem checkOutBtn = new UIBarButtonItem ("Checkout", UIBarButtonItemStyle.Plain, checkout_click);
				editBtn.TintColor = UIColor.White;
				this.TabBarController.NavigationItem.LeftBarButtonItem = checkOutBtn;
				
			}
		}

		private void checkout_click(object sender,EventArgs e){

			if (Globals.Cart.Count == 0)
				return;

			decimal sum = default(decimal);

			foreach (var item in Globals.Cart) 
				sum += item.Price;

			UIAlertController alertController = UIAlertController.Create ("Checkout", String.Format ("Total amount {0}$", sum),UIAlertControllerStyle.ActionSheet);
			alertController.AddAction (UIAlertAction.Create ("OK", UIAlertActionStyle.Default, a=>{
				Globals.Cart.Clear();
				TabBarController.TabBar.Items[1].BadgeValue=null;
				this.TableView.ReloadData();
			}
			));

			this.PresentViewController (alertController, true, null);
		}

		private void editBtn_click(object sender,EventArgs e){

			if (!this.TableView.Editing) {
				this.TableView.SetEditing (true,true);
				return;
			}

			this.TableView.SetEditing (false, true);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			this.TabBarController.NavigationItem.RightBarButtonItem = null;

			if (this.TabBarController.NavigationItem.LeftBarButtonItem != null)
				this.TabBarController.NavigationItem.LeftBarButtonItem = null;
		}
	}
}
