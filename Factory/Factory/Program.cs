using Factory;

NotificationFactory factory = new NotificationFactory();

// Create email notification
INotification emailNotification = factory.CreateNotification("email");
emailNotification.Send("Hello from the email notification!");

// Create SMS notification
INotification smsNotification = factory.CreateNotification("sms");
smsNotification.Send("Hello from the SMS notification!");

Console.ReadKey();