using System;
using NotificationApp.Protocol;
using Xamarin.Forms;

namespace NotificationApp
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            this.MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override async void OnResume()
        {
            // Handle when your app resumes
            var clickActionValue = DependencyService.Get<IClickActionValue>().Get();

            if (!string.IsNullOrEmpty(clickActionValue) && clickActionValue.Equals("page1", StringComparison.InvariantCultureIgnoreCase))
            {
                this.MainPage.Navigation.InsertPageBefore(new Page1(), this.MainPage.Navigation.NavigationStack[0]);
                await this.MainPage.Navigation.PopToRootAsync();
            }
            else if (!string.IsNullOrEmpty(clickActionValue) && clickActionValue.Equals("page2", StringComparison.InvariantCultureIgnoreCase))
            {
                this.MainPage.Navigation.InsertPageBefore(new Page2(), this.MainPage.Navigation.NavigationStack[0]);
                await this.MainPage.Navigation.PopToRootAsync();
            }
        }
    }
}