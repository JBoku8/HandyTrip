using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using System.Linq;
using CoreAnimation;

namespace hackTbilisi
{
	partial class DetailsViewController : UIViewController
	{
		public Souvenir Souvenir {
			get;
			set;
		}
		
		public DetailsViewController (IntPtr handle) : base (handle)
		{
		}

		private void initUI(){


			firstImageView.UserInteractionEnabled = true;
			secImageView.UserInteractionEnabled = true;

			if (firstImageView.Image != null) {
				firstImageView.Layer.BorderWidth = 0.5f;
				firstImageView.Layer.BorderColor = UIColor.Gray.CGColor;
			}

			if (secImageView.Image != null) {
				secImageView.Layer.BorderWidth = 0.5f;
				secImageView.Layer.BorderColor = UIColor.Gray.CGColor;
			}
	
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			if (Globals.Cart.Exists (o => o.Id == this.Souvenir.Id)) {
				addBtn.SetTitle ("Already added", UIControlState.Normal);
				addBtn.Enabled = false;
			}

			addBtn.TouchUpInside += addBtn_click;
			locationsBtn.TouchUpInside += locationsBtn_clicked;

			UIImage currMainImage = UIImage.FromFile ("Images/" + Souvenir.ImgUrls [0]);
			imageView.Image = currMainImage;
			nameLbl.Text = Souvenir.Name;
			priceLbl.Text = String.Format("Price : {0}$",Souvenir.Price.ToString("##.##"));

			if (Souvenir.ImgUrls.Count >= 2) {

				firstImageView.Image = UIImage.FromFile ("Images/" + Souvenir.ImgUrls [1]);

				if (Souvenir.ImgUrls.Count == 3)
					secImageView.Image = UIImage.FromFile ("Images/" + Souvenir.ImgUrls [2]);
			}

			initUI ();

		}

		private void locationsBtn_clicked(object sender,EventArgs e){

			this.PerformSegue ("mapsSegue", this);
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "mapsSegue") {

				var viewController = segue.DestinationViewController as LocationViewController;
				viewController.Locations = Souvenir.Locations;
			}
		}

		private void addBtn_click(object sender,EventArgs e){


			Globals.Cart.Add (this.Souvenir);
			var tabbarController = UIApplication.SharedApplication.KeyWindow.RootViewController.ChildViewControllers [0] as UITabBarController;
			tabbarController.TabBar.Items [1].BadgeValue = Globals.Cart.Count.ToString ();
			this.NavigationController.PopViewController (true);
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);

			UITouch currObject = touches.AnyObject as UITouch;//touch obieqts vigebt dacheraze romelic sheicavs View propertys im views romelzec davachiret
			//da aucileblad userinteractions enabled true unda iyos

			if (currObject.View.GetType () == typeof(UIImageView) && currObject.View !=imageView) {

				var mainImage = imageView.Image;

				UIImageView currImageView = currObject.View as UIImageView;

				imageView.Image = currImageView.Image;//shecvlamde animacias vanichebt
				CATransition transition = new CATransition ();
				transition.Duration = 0.3;
				transition.Type=CAMediaTimingFunction.EaseInEaseOut;

				imageView.Layer.AddAnimation (transition, String.Empty);
				currImageView.Image = mainImage;

			}
		}
	}
}
