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

namespace Test1
{
    public partial class SelectCategory : PhoneApplicationPage
    {
        public SelectCategory()
        {
            InitializeComponent();
        }

        public static string Category = "";

        private void AidButtonClicked(object sender, RoutedEventArgs e)
        {
            Category = "Aid";
            NavigationService.GoBack();
        }

        private void DonateButtonClicked(object sender, RoutedEventArgs e)
        {
            Category = "Donate";
            NavigationService.GoBack();
        }

        private void FeedButtonClicked(object sender, RoutedEventArgs e)
        {
            Category = "Feed";
            NavigationService.GoBack();
        }

        private void RaiseButtonClicked(object sender, RoutedEventArgs e)
        {
            Category = "Raise";
            NavigationService.GoBack();
        }

        private void ButtonFiveClicked(object sender, RoutedEventArgs e)
        {
            Category = "Five";
            NavigationService.GoBack();
        }
    }
}