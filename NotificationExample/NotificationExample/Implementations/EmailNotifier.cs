using NotificationExample.Interfaces;

namespace NotificationExample.Implementations
{
    internal class EmailNotifier : INotifier
    {
        public void SendNotification(string notification)
        {
            Console.WriteLine($"Sending Notification by Email: {notification}");
        }
    }
}
