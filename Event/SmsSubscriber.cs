using System;

namespace NotificationSystem
{
    internal class SmsSubscriber
    {
        public static void SmsEventHandler()
        {
            Console.WriteLine("SMS Notification Sent.");
        }
    }
}
