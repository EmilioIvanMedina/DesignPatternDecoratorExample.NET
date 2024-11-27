using NotificationExample.Interfaces;

namespace NotificationExample.Decorators
{
    internal class SmsNotifier : NotifierDecorator
    {
        public SmsNotifier(INotifier notifier) : base(notifier)
        {
        }

        public override void SendNotification(string notification)
        {
            base.SendNotification(notification);
            Console.WriteLine($"Send message by SMS: {notification}");
        }
    }
}
