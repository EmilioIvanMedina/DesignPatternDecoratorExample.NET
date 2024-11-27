using NotificationExample.Interfaces;

namespace NotificationExample.Decorators
{
    internal abstract class NotifierDecorator : INotifier
    {
        protected readonly INotifier _notifier;

        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void SendNotification(string notification)
        {
            _notifier.SendNotification(notification);
        }
    }
}
