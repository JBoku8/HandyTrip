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
	[Register ("DetailsViewController")]
	partial class DetailsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton addBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView firstImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton locationsBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel nameLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel priceLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView secImageView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (addBtn != null) {
				addBtn.Dispose ();
				addBtn = null;
			}
			if (firstImageView != null) {
				firstImageView.Dispose ();
				firstImageView = null;
			}
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
			if (locationsBtn != null) {
				locationsBtn.Dispose ();
				locationsBtn = null;
			}
			if (nameLbl != null) {
				nameLbl.Dispose ();
				nameLbl = null;
			}
			if (priceLbl != null) {
				priceLbl.Dispose ();
				priceLbl = null;
			}
			if (secImageView != null) {
				secImageView.Dispose ();
				secImageView = null;
			}
		}
	}
}
