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
	[Register ("DetailSightViewController")]
	partial class DetailSightViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel commentLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView mapView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel nameLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView prizeImageView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (commentLbl != null) {
				commentLbl.Dispose ();
				commentLbl = null;
			}
			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
			if (mapView != null) {
				mapView.Dispose ();
				mapView = null;
			}
			if (nameLbl != null) {
				nameLbl.Dispose ();
				nameLbl = null;
			}
			if (prizeImageView != null) {
				prizeImageView.Dispose ();
				prizeImageView = null;
			}
		}
	}
}
