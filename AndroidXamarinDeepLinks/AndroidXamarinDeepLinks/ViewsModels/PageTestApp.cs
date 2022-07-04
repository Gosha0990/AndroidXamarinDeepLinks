using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AndroidXamarinDeepLinks.ViewsModels
{
    public class PageTestApp : ContentPage
    {

        public PageTestApp()
        {
            Title = "PageTestApp";

            var LablePage = new Label()
            {
                Text = "Побочная строница App",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24

            };

            Button backButton = new Button
            {
                Text = "Назад",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            backButton.Clicked += BackButton_Click;
            Content = new StackLayout { Children = {backButton, LablePage}};
        }
        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
    
}