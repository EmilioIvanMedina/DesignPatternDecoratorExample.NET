// See https://aka.ms/new-console-template for more information
using NotificationExample.Implementations;
using NotificationExample.Decorators;
using NotificationExample.Interfaces;

Console.Write("Write the notification to send: ");
var notification = Console.ReadLine();

INotifier notifier = new EmailNotifier();

notifier = new PushNotifier(notifier);

notifier = new SmsNotifier(notifier);

notifier.SendNotification(notification);

Console.ReadKey();
