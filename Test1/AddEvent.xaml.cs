﻿using System;
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
using System.Collections.ObjectModel;

namespace Test1
{
    public partial class AddEvent : PhoneApplicationPage
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Note newEvent = new Note 
                { 
                Title = textTitle.Text,
                NoteText = textNote.Text,
                CreateDate = DateTime.Now,
                EventDate = timeTextbox.Text,
                EventLocation = locationTextbox.Text,
                EventCategory=CategoryTextBox.Text,
                EventCategoryGraphic=CategoryImage.Source;
                };
            newEvent.Save();

        NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListPage.xaml", UriKind.Relative));
        }

        private void setlocationbuttonclicked(object sender, RoutedEventArgs e)
        {
            //TODO: This button should allow the user to choose a location by typing it in.
            locationTextbox.Text = "123 Fake St., Bangor ME 04401";
        }

        private void settimebuttonclicked(object sender, RoutedEventArgs e)
        {
            //TODO: This button should allow the user to set the time they want the event to take place. Uses a GUI inside of a new window.
            timeTextbox.Text = "12:00 PM";
        }

        private void SetCategoryButtonClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SelectCategory.xaml", UriKind.Relative));
            
            //sort of works. Not really.
            //OnNavigatedTo():
            CategoryTextBox.Text = SelectCategory.Category;
            if (SelectCategory.Category == "Aid")
            {
                
            }
            else if (SelectCategory.Category == "Donate")
            {

            }
            else if (SelectCategory.Category == "Feed")
            {

            }
            else if (SelectCategory.Category == "Raise")
            {

            }

        }

        
    }
}