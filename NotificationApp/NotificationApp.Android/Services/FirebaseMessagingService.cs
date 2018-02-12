using Android.App;
using Firebase.Messaging;
using Xamarin.Forms;

namespace NotificationApp.Droid.Services
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class FirebaseMessagingService : Firebase.Messaging.FirebaseMessagingService
    {
        public override void OnMessageReceived(RemoteMessage message)
        {
            var notification = message.GetNotification();

            MessagingCenter.Send<object, string>(this, "firebase", notification.Body);
        }
    }
}