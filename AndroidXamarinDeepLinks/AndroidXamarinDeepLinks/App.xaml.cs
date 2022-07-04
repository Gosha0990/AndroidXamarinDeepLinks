using System;
using Xamarin.Forms;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Xamarin.Forms.Xaml;
using Prism.Navigation.Xaml;
using AndroidXamarinDeepLinks.ViewsModels;

namespace AndroidXamarinDeepLinks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

       protected override void OnAppLinkRequestReceived(Uri uri)
       {
            var action = uri.Segments[1].Replace("/", "");

            switch (action)
            {
                case "hello":
                   MainPage = new NavigationPage(new MainPage());
                    break;

                case "app":
                    MainPage = new NavigationPage(new PageTestApp());
                    break;

                default:
                    Xamarin.Forms.Device.OpenUri(uri);
                    break;
            }
        }
    }
}
