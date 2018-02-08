using Android.App;
using Android.Util;
using Firebase.Iid;

namespace NotificationApp.Droid.Services
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class FirebaseIIDService : FirebaseInstanceIdService
    {
        public override void OnTokenRefresh()
        {
            var token = FirebaseInstanceId.Instance.Token;

            Log.Debug("NotificationApp", token);
        }
    }
}