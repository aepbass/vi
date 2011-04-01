using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using Microsoft.Phone.Controls;
using System.Device.Location;

namespace Test1
{
    public partial class LocationSettings : PhoneApplicationPage
    {
        #region geowatcher
        GeoCoordinateWatcher watcher;

        #endregion


        #region buttons
        public LocationSettings()
        {
            InitializeComponent();

        }

        private void backbuttonclicked(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void SetToCurrentLocationclicked(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}