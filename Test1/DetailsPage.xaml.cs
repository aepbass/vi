using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class DetailsPage : PhoneApplicationPage
    {
        // Constructor
        public DetailsPage()
        {
            InitializeComponent();
        }

        private int index;

        // When page is navigated to, set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                index = int.Parse(selectedIndex);
                DataContext = App.ViewModel.Items[index];
            }
        }

        private void appbar_button1_Click(object sender, EventArgs e)
        {
            if (index < App.ViewModel.Items.Count)
            {
                App.ViewModel.Items.RemoveAt(index);
                StorageHelper.Save<ObservableCollection<Note>>(App.NotesFileName, App.ViewModel.Items);
            }
            NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }

        private void appbar_button2_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }
    }
}