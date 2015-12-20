using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Linq;
using CoreLocation;
using MapKit;

namespace hackTbilisi
{
	partial class DetailSightViewController : UIViewController
	{
		CLLocationManager _coreLocationManager;

		public class PlaceLocation : MKAnnotation{
			public override CLLocationCoordinate2D Coordinate {get{ return _cords;}}
			CLLocationCoordinate2D _cords;
			string title, subtitle;
			public override string Title { get{ return title; }}
			public override string Subtitle { get{ return subtitle; }}
			public PlaceLocation (double latitude,double longitude) {

				_cords= new CLLocationCoordinate2D (latitude, longitude);

				//this.Coordinate = coordinate;
				//this.title = title;
				//this.subtitle = subtitle;

			}
		}
		
		public Sight Sight {
			get;
			set;
		}
		
		public DetailSightViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_coreLocationManager = new CLLocationManager ();
			_coreLocationManager.RequestAlwaysAuthorization ();

			MKCoordinateRegion region=new MKCoordinateRegion();
			region.Center = new CLLocationCoordinate2D (Sight.Location.ElementAt (0).Latitude, Sight.Location.ElementAt (0).Longitude);

			MKCoordinateSpan span;
			span.LatitudeDelta=0.1;
			span.LongitudeDelta=0.1;

			region.Span=span;

			mapView.SetRegion(region,true);


			foreach (var item in Sight.Location) {

				PlaceLocation placeLocation = new PlaceLocation(item.Latitude,item.Longitude);
				this.mapView.AddAnnotation (placeLocation);
			}

			this.imageView.Image = UIImage.FromFile ("Images/" + Sight.ImageUrl);
			this.nameLbl.Text = Sight.Name;
			commentLbl.Text = Sight.Comment;

			UIImage prizeImage = UIImage.FromFile ("Images/" + Globals.SecSouveniers.Where (o => o.Id == Sight.PriceId).SingleOrDefault ().ImgUrls [0]);
			prizeImageView.Image = prizeImage;

		}
	}
}
