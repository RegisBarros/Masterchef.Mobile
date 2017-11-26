﻿using Masterchef.Mobile.App.Views;
using Xamarin.Forms;

namespace Masterchef.Mobile.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RecipeListPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
