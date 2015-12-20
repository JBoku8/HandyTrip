using System;
using System.Collections.Generic;

namespace hackTbilisi
{
	public class Location{

		public double Latitude {
			get;
			set;
		}

		public double Longitude {
			get;
			set;
		}
	}

	public class SouvenirCompany{

		public int Id {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public string Address {
			get;
			set;
		}

		public List<Souvenir> Souveniers {
			get;
			set;
		}

	}
	
	public class Souvenir
	{
		public string Id {
			get;
			set;
		}

		public SouvenirCompany Company {
			get;
			set;
		}

		public string CountryName {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public List<string> ImgUrls {
			get;
			set;
		}

		public decimal Price {
			get;
			set;
		}

		public List<Location> Locations {
			get;
			set;
		}

		public Souvenir ()
		{
		}
	}

	public class Sight{

		public int Id {
			get;
			set;
		}

		public string PriceId {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public string Comment {
			get;
			set;
		}

		public string ImageUrl {
			get;
			set;
		}

		public List<Location> Location {
			get;
			set;
		}

	}
}

