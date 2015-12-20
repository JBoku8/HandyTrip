using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreLocation;
using MapKit;
using System.Collections.Generic;
using System.Linq;

namespace hackTbilisi
{
	partial class LocationViewController : UIViewController
	{
		public List<Location> Locations{get;set;}
		
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

		public LocationViewController (IntPtr handle) : base (handle)
		{
					
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_coreLocationManager = new CLLocationManager ();
			_coreLocationManager.RequestAlwaysAuthorization ();

			MKCoordinateRegion region=new MKCoordinateRegion();

			if (Locations.Count != 0)
				region.Center = new CLLocationCoordinate2D (Locations.ElementAt (0).Latitude, Locations.ElementAt (0).Longitude);

			MKCoordinateSpan span;
			span.LatitudeDelta=0.1;
			span.LongitudeDelta=0.1;

			region.Span=span;

			mapView.SetRegion(region,true);


			foreach (var item in Locations) {

				PlaceLocation placeLocation = new PlaceLocation(item.Latitude,item.Longitude);
				this.mapView.AddAnnotation (placeLocation);
			}
		}
	}
}
