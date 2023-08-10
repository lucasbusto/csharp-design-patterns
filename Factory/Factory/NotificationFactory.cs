namespace Factory
{
    public class NotificationFactory
    {
        public INotification CreateNotification(string type)
        {
            switch (type)
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SmsNotification();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }
}
