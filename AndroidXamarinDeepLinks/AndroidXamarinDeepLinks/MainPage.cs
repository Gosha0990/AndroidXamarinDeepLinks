using AndroidXamarinDeepLinks.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AndroidXamarinDeepLinks
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Pege Hello";
            var LablePage = new Label()
            {
                Text = "Главная странис со ссылки Hello",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24
                
            };
            Button toCommonPageBtn = new Button
            {
                Text = "На Page App",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toCommonPageBtn.Clicked += ToCommonPage;
            
            Content = new StackLayout { Children = { toCommonPageBtn, LablePage } };
        }

        private async void ToCommonPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTestApp());
        }
    }
}