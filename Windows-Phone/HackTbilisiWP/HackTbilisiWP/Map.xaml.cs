using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace HackTbilisiWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Map : Page
    {
        public Map()
        {
            this.InitializeComponent();

            HardwareButtons.BackPressed += (object sender, BackPressedEventArgs e) => { if (this.Frame.CanGoBack) this.Frame.GoBack(); e.Handled = true; };

            
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MyMap.ZoomLevel = 15;
            Souvenier souv = e.Parameter as Souvenier;
            MyMap.Center = souv.Geopoints[0];

            var image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Images/pin1.png"));
            var anchorPoint = new Point(0.5, 1);
            foreach (var geo in souv.Geopoints)
            {
                
                var shape = new MapIcon
                {
                    Location = geo,
                    NormalizedAnchorPoint = anchorPoint,
                    Image = image
                };

                MyMap.MapElements.Add(shape);
            }
        }



    }
}
