using NotificationApp.Protocol;

namespace NotificationApp.iOS
{
    public class IOSClickActionValue : IClickActionValue
    {
        public static readonly IOSClickActionValue Instance = new IOSClickActionValue();
        private readonly object lockedObject = new object();
        private string value;

        private IOSClickActionValue()
        {
        }

        public void Set(string value)
        {
            this.value = value;
        }

        public string Get()
        {
            lock (this.lockedObject)
            {
                var clickAction = this.value;
                this.value = default(string);

                return clickAction;
            }
        }

        public string Peek()
        {
            return this.value;
        }
    }
}