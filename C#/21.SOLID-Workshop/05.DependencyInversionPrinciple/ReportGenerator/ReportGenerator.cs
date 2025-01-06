namespace _05.DependencyInversionPrinciple.ReportGenerator
{
    public class ReportGenerator
    {
        private IEmailSender _emailSender;
        private IDocumentGenerator _pdfGenerator;
        public ReportGenerator(EmailSender sender, PDFGenerator generator)
        {
            _emailSender = sender;
            _pdfGenerator = generator;
        }

        public string GenerateReport()
        {
            return _pdfGenerator.GenerateDocument();
        }

        public void SendReport(string email)
        {
            var report = GenerateReport();
            _emailSender.SendEmail(email, report);
        }
    }
}
