﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ErasmusApp
{
    public partial class CountrySelect : PhoneApplicationPage
    {
        public CountrySelect()
        {
            InitializeComponent();

            DataContext = App.ViewModel;

        }

        private void ExpandedContentButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CitySelect.xaml", UriKind.Relative));
        }

    }
}