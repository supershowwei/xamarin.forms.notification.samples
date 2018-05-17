using System;
using NotificationApp.iOS;
using NotificationApp.Protocol;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOSClickActionValueWrapper))]

namespace NotificationApp.iOS
{
    public class IOSClickActionValueWrapper : IClickActionValue
    {
        private readonly IClickActionValue clickActionValue;

        public IOSClickActionValueWrapper()
        {
            this.clickActionValue = IOSClickActionValue.Instance;
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