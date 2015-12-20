using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Media.Imaging;

namespace HackTbilisiWP
{
    class Classes
    {
    }

    public static class Souveniers
    {
        public static List<Souvenier> souveniers { get; set; }
        static Souveniers()
        {
            souveniers = new List<Souvenier>()
            {
                
                new Souvenier() {
                    Name = "Eiffel tower keyring",
                    Description = "100% Brand new Cute,3D,Eiffel Tower Charm Pendant Material: Alloy Dimensions: Height 5cm (excluding key chains trap) Weight: approx 9grams Color. Completed on March 31, 1889, the tower was the world’s tallest man-made structure for 41 years until the completion of the Chrysler Building in New York in 1930.",
                    ImageSourses =new BitmapImage(new Uri("ms-appx:///Images/eiffel4.jpg")),
                    Price = "2.99 $",
                    IsChecked = false,
                    Rating =3.7,
                    JustImageSources = new List<JustImageSource>()
                    {
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/eiffel4.jpg")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/eiffel2.jpg")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/eiffel3.jpg")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/eiffel1.jpg")) },
                    },
                    Geopoints =  new List<Geopoint>(){
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.866629, Longitude = 2.337343}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.865867, Longitude =  2.340749}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.860422, Longitude =2.346063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.862422, Longitude =2.342063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.87422, Longitude =2.348063}),
                    }

                },
                
                
                new Souvenier() {
                    Name = "Ancient Greek",
                    Description = "Coins were first made of scraps of metal. Ancient coins were produced through a process of hitting a hammer positioned over an anvil. The Chinese produced primarily cast coinage, and this spread to South-East Asia and Japan. Relatively few non-Chinese cast coins were produced by governments, however it was a common practice amongst counterfeiters. Since the early 18th century and before, presses (normally referred to as mills in coin collecting circles) have been used in the west, beginning with screw presses and progressing in the 19th century towards steam driven presses. The first of these presses were developed in France and Germany, and quickly spreading to Britain.Modern minting techniques use electric and hydraulic presses.",
                    ImageSourses =new BitmapImage(new Uri("ms-appx:///Images/icon1.jpg")),
                    Price = "20 $",
                    IsChecked = false,
                    Rating =4.5,
                    JustImageSources = new List<JustImageSource>()
                    {
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/icon1.jpg")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/icon2.jpg")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/icon3.jpg")) },
                        
                    },

                    Geopoints =  new List<Geopoint>(){
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.866629, Longitude = 2.337343}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.865867, Longitude =  2.340749}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.860422, Longitude =2.346063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.862422, Longitude =2.342063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.87422, Longitude =2.348063}),
                    }
                },
                new Souvenier() {
                    Name = "Silver spoon with ornaments",
                    Description = "Preserved examples of various forms of spoons used by the ancient Egyptians include those composed of ivory, flint, slate and wood; many of them carved with religious symbols.[1] During the Neolithic Ozieri civilization in Sardinia, ceramic ladles and spoons were already in use. In Shang Dynasty China, spoons were made of bone. Early bronze spoons in China were designed with a sharp point, and may have also been used as cutlery.[2] Ancient Indian texts also refer to the use of spoons. For example, the Rigveda refers to spoons during a passage describing the reflection of light as it s mout (RV 8.43.10).[3] The spoons of the Greeks and Romans were chiefly made of bronze and silver and the handle usually takes the form of a spike or pointed stem.[1] There are many examples in the British Museum from which the forms of the various types can be ascertained, the chief points of difference being found in the junction of the bowl with the handle.",
                    ImageSourses =new BitmapImage(new Uri("ms-appx:///Images/spoon1.jpg")),
                    Price = "35 $",
                    IsChecked = false,
                    Rating =1.5,
                    JustImageSources = new List<JustImageSource>()
                    {
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/spoon1.jpg")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/spoon2.jpg")) },
                        
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/spoon3.jpg")) },
                    },
                    Geopoints =  new List<Geopoint>(){
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.866629, Longitude = 2.337343}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.865867, Longitude =  2.340749}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.860422, Longitude =2.346063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.862422, Longitude =2.342063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.87422, Longitude =2.348063}),
                    }
                },
                new Souvenier() {
                    Name = "Georgian horn",
                    IsChecked = false,
                    Description = "Georgian traditional horn with beautiful ornaments",
                    ImageSourses =new BitmapImage(new Uri("ms-appx:///Images/yanwi.png")),
                    Price = "29.99 $",
                    Rating =4.8,
                    JustImageSources = new List<JustImageSource>()
                    {
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/yanwi.png")) },
                    },
                    Geopoints =  new List<Geopoint>(){
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.866629, Longitude = 2.337343}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.865867, Longitude =  2.340749}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.860422, Longitude =2.346063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.862422, Longitude =2.342063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.87422, Longitude =2.348063}),
                    }
                },
                new Souvenier() {
                    Name = "Indian oil lamp",
                    Description = "In the home shrine, the style of lamp is usually different, containing only one wick. There is usually a piece of metal that forms the back of the lamp, which has a picture of a Hindu deity embossed on it. In many houses, the lamp burns all day, but in other homes, it is lit at sundown. The lamp in the home shrine is supposed to be lit before any other lights are turned on at night.",
                    ImageSourses =new BitmapImage(new Uri("ms-appx:///Images/india1.png")),
                    IsChecked = false,
                    Price = "22.59 $",
                    Rating =2.3,
                    JustImageSources = new List<JustImageSource>()
                    {
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/india1.png")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/india2.png")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/india3.png")) },
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/india4.png")) },
                    },
                    Geopoints =  new List<Geopoint>(){
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.866629, Longitude = 2.337343}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.865867, Longitude =  2.340749}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.860422, Longitude =2.346063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.862422, Longitude =2.342063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.87422, Longitude =2.348063}),
                    }
                },
                new Souvenier() {
                    Name = "Handmade sword",
                    Description = "Georgian handmade sword",
                    ImageSourses =new BitmapImage(new Uri("ms-appx:///Images/sword.png")),
                    Price = "15 $",
                    IsChecked = false,
                    Rating =4.4,
                    JustImageSources = new List<JustImageSource>()
                    {
                        new JustImageSource() {ImageSourses = new BitmapImage(new Uri("ms-appx:///Images/sword.png")) },
                    },
                    Geopoints =  new List<Geopoint>(){
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.866629, Longitude = 2.337343}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.865867, Longitude =  2.340749}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.860422, Longitude =2.346063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.862422, Longitude =2.342063}),
                                     new Geopoint(new BasicGeoposition(){ Latitude = 48.87422, Longitude =2.348063}),
                    }
                },
            };
        }
    }
    public class Souvenier
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public BitmapImage ImageSourses { get; set; }

        public string Price { get; set; }

        public double Rating { get; set; }

        public bool IsChecked { get; set; }

        public List<JustImageSource> JustImageSources { get; set;}

        public List<Geopoint> Geopoints { get; set; }
    }

    public class JustImageSource
    {
        public BitmapImage ImageSourses { get; set; }
    }

    public static class ToogleButtons
    {
        public static List<Souvenier> souveniers;
        static ToogleButtons()
        {
            souveniers = new List<Souvenier>();
        }
    }

    
}
