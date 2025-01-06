namespace _05.DependencyInversionPrinciple.ReportGenerator
{
    public class PDFGenerator : IDocumentGenerator
    {
        public string GenerateDocument()
        {
            return "Generated PDF";
        }
    }
}
