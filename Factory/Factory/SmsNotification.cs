namespace Factory
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS notification: " + message);
        }
    }
}
