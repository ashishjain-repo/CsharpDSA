namespace EmailAbstract
{
    public class Email
    {
        public void SendEmail()
        {
            Connet();
            Authenticate();
            System.Console.WriteLine("Sending email...");
            Disconnect();
        }
        private void Connet()
        {
            System.Console.WriteLine("Connecting to email server...");
        }
        private void Authenticate()
        {
            System.Console.WriteLine("Authenticating...");
        }
        private void Disconnect()
        {
            System.Console.WriteLine("Disconnecting from email server...");
        }
    }
}