using EmailAbstract;

public class Program
{
    public static void Main(string[] args)
    {
        EmailService emailService = new EmailService();
        emailService.Connect();
        emailService.Authenticate();
        emailService.SendEmail();
        emailService.Disconnect();

        Email email = new Email();
        email.SendEmail();
    }
}