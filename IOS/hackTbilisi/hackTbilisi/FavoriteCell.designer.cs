// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace hackTbilisi
{
	[Register ("FavoriteCell")]
	partial class FavoriteCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton addbtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView holderView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel nameLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton removeBtn { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (addbtn != null) {
				addbtn.Dispose ();
				addbtn = null;
			}
			if (holderView != null) {
				holderView.Dispose ();
				holderView = null;
			}
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
			if (nameLbl != null) {
				nameLbl.Dispose ();
				nameLbl = null;
			}
			if (removeBtn != null) {
				removeBtn.Dispose ();
				removeBtn = null;
			}
		}
	}
}
