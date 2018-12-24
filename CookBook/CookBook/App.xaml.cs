using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CookBook.Services;
using CookBook.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CookBook
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        public static string AzureBackendUrl = "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            MainPage = new NavigationPage(new HomePage());
        }


        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("ios={49042b84-6586-45a1-9762-c26e73ca8e9b};android={b6b36088-7ccf-4e25-95d9-79761f880ee8}}", typeof(Analytics), typeof(Crashes));
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
