namespace _05.DependencyInversionPrinciple.ReportGenerator
{
    public interface IEmailSender
    {
        void SendEmail(string recipient, string content);
    }
}
