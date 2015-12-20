using System;
using System.Collections.Generic;

namespace hackTbilisi
{
	public class Globals
	{
		public static List<SouvenirCompany> SouvenirCompanies;
		public static List<Souvenir> Souveniers;
		public static List<Souvenir> SecSouveniers;
		public static List<Souvenir> MyFavorites =new List<Souvenir>();
		public static List<Souvenir> Cart = new List<Souvenir>();
		public static List<Sight> Sights;
		
		static Globals ()
		{
			SouvenirCompanies = new List<SouvenirCompany> (){new SouvenirCompany(){Id=0,Name="France Souveniers LTD",Address="paris eifel"},
				new SouvenirCompany(){Id=0,Name="La Paris Souveniers LTD",Address="paris eifel"}
			};

			SecSouveniers = new List<Souvenir> (){
				new Souvenir(){Id="1215235",CountryName="Paris",Name="Eifel Iphone case",ImgUrls= new List<string>(){"case.png"},Price=8.00m,Company=SouvenirCompanies[1],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},
				new Souvenir(){Id="121125235",CountryName="Paris",Name="Magnetic eifel",ImgUrls= new List<string>(){"fridge.png","magnet2.png","magnet3.png"},Price=3.00m,Company=SouvenirCompanies[1],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},
				new Souvenir(){Id="1211245235",CountryName="Paris",Name="Eifel key holders",ImgUrls= new List<string>(){"keyh.png","keyhold2.png","keyhold3.png"},Price=1.00m,Company=SouvenirCompanies[1],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},
				new Souvenir(){Id="1214565235",CountryName="Paris",Name="Eifel ,Triumphal arch",ImgUrls= new List<string>(){"sectest.png"},Price=8.00m,Company=SouvenirCompanies[1],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},
				new Souvenir(){Id="121261215235",CountryName="Paris",Name="Eifel Snowball",ImgUrls= new List<string>(){"snowball.png"},Price=5.00m,Company=SouvenirCompanies[1],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}}
			};
			Souveniers = new List<Souvenir> (){
				new Souvenir(){Id="48602587",CountryName="Paris",Name="Marlboro F1 badge",ImgUrls= new List<string>(){"marlboroBadge.jpg"},Price=5.00m,Company=SouvenirCompanies[0],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},
				new Souvenir(){Id="5941194002553",CountryName="Paris",Name="Paris tier Golden",ImgUrls= new List<string>(){"parisGold.jpg"},Price=20.00m,Company=SouvenirCompanies[0],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},
				new Souvenir(){Id="5060005722098",CountryName="England",Name="Stonehange",ImgUrls= new List<string>(){"stonehange.jpg"},Price=2.00m,Company=SouvenirCompanies[0],Locations = new List<Location>(){new Location(){Latitude=48.841328,Longitude=2.255522},new Location(){Latitude=48.842048,Longitude=2.254728},new Location(){Latitude=48.841801,Longitude=2.256005}}},

			};

			Sights = new List<Sight> (){new Sight(){Id=0,Name="Eifel & Triumphal arch",PriceId="1214565235",Comment="Discover beauty of paris Eifel tower and also triumphal arch and earn great souvenir!",Location=new List<Location>(){new Location(){Latitude=48.858624,Longitude=2.294481},new Location(){Latitude=48.873820,Longitude=2.294899}},ImageUrl="eifelandarc.png"}};
				
		}


	}
}

