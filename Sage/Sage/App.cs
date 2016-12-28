using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Sage
{
    public class App : Application
    {
        public App()
        {
            ContentPage master = new ContentPage();

            Button searchTopicsButton = new Button
            {
                Text = "Search Topics",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            searchTopicsButton.Clicked += loadSearchTopics;

            Button connectDatabaseButton = new Button
            {
                Text = "Connect to Database",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            //connectDatabaseButton.Clicked += connectDatabase;

            Button webViewButton = new Button
            {
                Text = "Display Web Page",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            webViewButton.Clicked += loadWebPage;

            ViewReference webContent = new ViewReference();

            // The root page of your application
            var content = new ContentPage
            {
                Title = "Sage",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                       webContent, webViewButton, searchTopicsButton,
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        private async void loadSearchTopics(object sender, EventArgs e)
        {
            await MainPage.Navigation.PushAsync(new SearchTopics());
        }

        private async void loadWebPage(object sender, EventArgs e)
        {
            ViewReference webContent = new ViewReference();
//            await MainPage.Navigation.PushAsync();
        }

        /* private void connectDatabase(object sender, EventArgs e)
         {
             DAL conn = new Sage.DAL();
             conn.OpenDatabaseConnection();
         }*/

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
