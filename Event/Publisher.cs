using System;

namespace NotificationSystem
{
    public delegate void NotificationDelegate();
    internal class Publisher
    {
        public event NotificationDelegate NotificationEvent; // Event creation

        public void TriggerNotification()
        {
            Console.WriteLine("Notification Process Started...");
            NotifySubscribers();
        }

        private void NotifySubscribers()
        {
            NotificationEvent?.Invoke(); // Invoke all subscribed methods
        }
    }
}
