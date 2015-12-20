using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public sealed partial class Cart : Page
    {
        public Cart()
        {
            this.InitializeComponent();
            mainList.ItemsSource = checkoutList.ItemsSource = ToogleButtons.souveniers;
            HardwareButtons.BackPressed += (object sender, BackPressedEventArgs e) => { if (this.Frame.CanGoBack) this.Frame.GoBack(); e.Handled = true; };
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            checkOutBtn.Content = "Proceed to checkout ( " + ToogleButtons.souveniers.Count +" items)";
            int num= ToogleButtons.souveniers.Count;
            
            double sum = ToogleButtons.souveniers.Sum(o => Double.Parse(o.Price.Remove(  (o.Price.Length-1))));

            Sum.Text = "Total number of items: " + num + "\nTotal price: " + sum + " $";
        }

        private void itemTapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(DetailsPage), Souveniers.souveniers.Find(o => o.Name == (((Grid)sender).Tag).ToString()));
        }

        private void NavToProfile(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile));
        }

        private void Checkout(object sender, RoutedEventArgs e)
        {
            
        }

        private void CheckoutClick(object sender, RoutedEventArgs e)
        {
            checkOutBtn.Flyout.Hide();
            var msg = new MessageDialog("All your items are purchased!");
            msg.ShowAsync();
            ToogleButtons.souveniers = new List<Souvenier>();
            Frame.Navigate(typeof(Cart));
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            checkOutBtn.Flyout.Hide();
        }
    }
}
