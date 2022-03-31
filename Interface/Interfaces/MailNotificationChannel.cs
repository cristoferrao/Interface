namespace Interface.Interfaces
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending Mail channel...");

        }
    }
}
