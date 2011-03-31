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
using System.Windows.Navigation;
using System.Device.Location;

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
using Microsoft.Phone.Controls.Maps.Core;

//using Test1.Bing.Route;

namespace Test1
{
    public partial class MapPage : PhoneApplicationPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        #region consts

        /// <value>Default map zoom level.</value>
        private const double DefaultZoomLevel = 18.0;

        /// <value>Maximum map zoom level allowed.</value>
        private const double MaxZoomLevel = 21.0;

        /// <value>Minimum map zoom level allowed.</value>
        private const double MinZoomLevel = 1.0;

        #endregion



        #region Fields

        //Map zoom level.
        private double _zoom;

        public double tempzoom = 1.0;
        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets the map zoom level. Needs work. Lots of work!
        /// </summary>
        public double Zoom
        {
            get { return _zoom; }
            set
            {
                var coercedZoom = Math.Max(MinZoomLevel, Math.Min(MaxZoomLevel, value));
                if (_zoom != coercedZoom)
                {
                    _zoom = value;
                    //NotifyPropertyChanged("Zoom");
                }
            }
        }



        #endregion



        #region buttons;

        //zoom buttons TEMPORARY VERSION
        private void zoominbuttonclicked(object sender, RoutedEventArgs e)
        {
            tempzoom = tempzoom + 2;
        }

        private void zoomoutbuttonclicked(object sender, RoutedEventArgs e)
        {
            tempzoom = tempzoom - 2;
        }


        //applicationbar stuff
        private void backbuttonclicked(object sender, EventArgs e)
        {
            // Navigate to the new page
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void centerbuttonclicked(object sender, EventArgs e)
        {
            return;
        }

        private void modebuttonclicked(object sender, EventArgs e)
        {
            ChangeMapMode();
        }

        private void menuitem1click(object sender, EventArgs e)
        {
            // Application bar menu item # 1 actions
            NavigationService.Navigate(new Uri("/AddEvent.xaml", UriKind.Relative));
        }

        private void menuitem2click(object sender, EventArgs e)
        {
            // Application bar menu item # 2 actions
            // Navigate to the new page
            NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }

        private void eventbuttonclicked(object sender, RoutedEventArgs e)
        {
            // Navigate to the new page
            NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }

        #endregion



        #region behaviors

        private void ChangeMapMode()
        {
            if (map1.Mode is AerialMode)
            {
                map1.Mode = new RoadMode();
            }
            else
            {
                map1.Mode = new AerialMode(true);
            }
        }

        #endregion

        
    }
}