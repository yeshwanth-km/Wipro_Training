using NotificationSystem;

namespace NotificationSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.NotificationEvent += SmsSubscriber.SmsEventHandler; // Register SMS handler
            publisher.NotificationEvent += PushSubscriber.PushEventHandler; // Register Push handler

            publisher.TriggerNotification();
        }
    }

}


