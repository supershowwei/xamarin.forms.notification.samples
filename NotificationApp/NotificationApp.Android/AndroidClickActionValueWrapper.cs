using System;
using NotificationApp.Droid;
using NotificationApp.Protocol;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidClickActionValueWrapper))]

namespace NotificationApp.Droid
{
    public class AndroidClickActionValueWrapper : IClickActionValue
    {
        private readonly IClickActionValue clickActionValue;

        public AndroidClickActionValueWrapper()
        {
            this.clickActionValue = AndroidClickActionValue.Instance;
        }

        public void Set(string value)
        {
            throw new NotSupportedException();
        }

        public string Get()
        {
            return this.clickActionValue.Get();
        }

        public string Peek()
        {
            return this.clickActionValue.Peek();
        }
    }
}