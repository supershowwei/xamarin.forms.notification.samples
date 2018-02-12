using NotificationApp.ViewModels;
using Xamarin.Forms;

namespace NotificationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.MainViewModel.FirebaseMessage = "Welcome to Xamarin.Forms!";

            MessagingCenter.Subscribe<object, string>(
                this,
                "firebase",
                (sender, msg) => Device.BeginInvokeOnMainThread(() => { this.MainViewModel.FirebaseMessage = msg; }));
        }

        private MainViewModel MainViewModel => (MainViewModel)this.BindingContext;
    }
}