namespace NotificationApp.Protocol
{
    public interface IClickActionValue
    {
        void Set(string value);

        string Get();

        string Peek();
    }
}