using NotificationExample.Interfaces;

namespace NotificationExample.Decorators
{
    internal class PushNotifier : NotifierDecorator
    {
        public PushNotifier(INotifier notifier) : base(notifier)
        {
        }

        public override void SendNotification(string notification)
        {
            base.SendNotification(notification);
            Console.WriteLine($"Push to cell and tablets : {notification}");
        }
    }
}
