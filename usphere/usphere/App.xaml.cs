﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using usphere.Views.ViewsAcceso;
using usphere.Views.procesosGenerales;

namespace usphere
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new StartPage());
            MainPage = new NavigationPage(new MainPage());
    
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
