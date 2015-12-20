using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
    public sealed partial class DetailsPage : Page
    {
        public DetailsPage()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += (object sender, BackPressedEventArgs e) => { if (this.Frame.CanGoBack) this.Frame.GoBack(); e.Handled = true; };
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            Souvenier souv = e.Parameter as Souvenier;
            foreach (var x in souv.JustImageSources)
            {
                Image img = new Image();
                img.Stretch = Stretch.UniformToFill;
                img.Source = x.ImageSourses;
                flipView.Items.Add(img);
            }
            Name.Text = souv.Name;
            Description.Text = souv.Description;
            Rating.Value = souv.Rating;
            Price.Text = souv.Price;

            if (ToogleButtons.souveniers.Contains(Souveniers.souveniers.Find(o => o.Name == Name.Text)))
                tglBTN.IsChecked = true;
            else
                tglBTN.IsChecked = false;
        }

        

        private void tglBTN_Click(object sender, RoutedEventArgs e)
        {
            if (ToogleButtons.souveniers.Contains(Souveniers.souveniers.Find(o => o.Name == Name.Text)))
                ToogleButtons.souveniers.Remove(Souveniers.souveniers.Find(o => o.Name == Name.Text));
            
            else
                ToogleButtons.souveniers.Add(Souveniers.souveniers.Find(o => o.Name == Name.Text));
            Frame.Navigate(typeof(Cart));
        }

        private async void NavToMap(object sender, RoutedEventArgs e)
        {
            //new MessageDialog((Souveniers.souveniers.Find(o => o.Name == Name.Text)).Name).ShowAsync();
            


            if (NetworkInterface.GetIsNetworkAvailable())
                Frame.Navigate(typeof(Map), Souveniers.souveniers.Find(o => o.Name == Name.Text));
            else
            {
                MessageDialog msgbox = new MessageDialog("NO internet connection...", "Map can't be loaded");
                await msgbox.ShowAsync();
            }
        }

        private void NavToProfile(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile));
        }

        private void NavToCart(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Cart));
        }
    }
}
