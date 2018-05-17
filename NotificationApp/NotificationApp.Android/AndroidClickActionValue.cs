using NotificationApp.Protocol;

namespace NotificationApp.Droid
{
    internal class AndroidClickActionValue : IClickActionValue
    {
        public static readonly AndroidClickActionValue Instance = new AndroidClickActionValue();
        private readonly object lockedObject = new object();
        private string value;

        private AndroidClickActionValue()
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