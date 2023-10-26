namespace DependencyInversionPrinciple
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            //Without DIP
            EmailNotificationWithout emailNotificationWithout = new EmailNotificationWithout();

            //With DIP
            EmailNotification emailNotification = new EmailNotification(new SmtpClient());
        }
    }
}