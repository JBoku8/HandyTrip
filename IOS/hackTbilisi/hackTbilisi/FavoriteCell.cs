using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace hackTbilisi
{
	partial class FavoriteCell : UITableViewCell
	{
		public FavoriteCell (IntPtr handle) : base (handle)
		{
		}

		public Action RemoveClicked{get;set;}
		public Action AddClicked{ get; set; }

		public void Initdata(Souvenir souvenir){

			UIImage image = UIImage.FromFile ("Images/" + souvenir.ImgUrls [0]);
			imageView.Image = image;

			nameLbl.Text = souvenir.Name;
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			holderView.Layer.CornerRadius = 10;
			holderView.Layer.ShadowColor = UIColor.Black.CGColor;
			holderView.Layer.ShadowOpacity = 0.4f;
			holderView.Layer.ShadowRadius = 3;
			holderView.Layer.ShadowOffset = new CoreGraphics.CGSize (2, 2);

			EventHandler removeClickhandler = null;
			removeClickhandler += delegate {
			
				if(RemoveClicked!=null)
					RemoveClicked();
				
				//removeBtn.TouchUpInside-=removeClickhandler;
			};

			removeBtn.TouchUpInside += removeClickhandler;

			addbtn.TouchUpInside += delegate {
				AddClicked.Invoke();
			};
		}
	}
}
