﻿namespace Factory
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending email notification: " + message);
        }
    }
}
