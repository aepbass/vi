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
using Microsoft.Phone.Controls;
using System.Windows.Navigation;

namespace Test1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void mapbuttonclick(object sender, RoutedEventArgs e)
        {
            // Navigate to the new page
            NavigationService.Navigate(new Uri("/MapPage.xaml", UriKind.Relative));
        }

        private void eventbuttonclicked(object sender, RoutedEventArgs e)
        {
            // Navigate to the new page
            NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }

        private void profileclicked(object sender, RoutedEventArgs e)
        {
            // Navigate to the new page
            NavigationService.Navigate(new Uri("/ProfilePage.xaml", UriKind.Relative));
        }

        private void locationbuttonclicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LocationSettings.xaml", UriKind.Relative));
        }
        
    }
}