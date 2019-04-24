﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Analyzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_page : ContentPage
    {
        public Start_page()
        {
            InitializeComponent();
        }

        private async void StartBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new search_page());
        }
    }
}