﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExchangeRatesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }


        private async void Checked_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void Sw_fir(object sender, ToggledEventArgs e)
        {

        }

        private void Sw_sec(object sender, ToggledEventArgs e)
        {

        }
    }
}