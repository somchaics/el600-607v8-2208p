using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sample1.Views;

namespace Sample1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new home());
           
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

//Namespace:Xamarin.Forms
//Assembly:Xamarin.Forms.Core.dll
//Gets or sets the root page of the application.
//public Xamarin.Forms.Page MainPage { get; set; }