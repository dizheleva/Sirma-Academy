using _05.DependencyInversionPrinciple.OrderService;
using _05.DependencyInversionPrinciple.ReportGenerator;

internal class Program
{
    private static void Main(string[] args)
    {
        var customerEmail = "customer@example.com";

        Console.WriteLine("Dependency Inversion Principle Example -> Report Generator");
        ReportGenerator reportGenerator = new ReportGenerator(new EmailSender(), new PDFGenerator());
        reportGenerator.SendReport(customerEmail);
        Console.WriteLine(reportGenerator.GenerateReport());

        Console.WriteLine();

        Console.WriteLine("Dependency Inversion Principle Example -> Order Service");
        OrderService orderService = new OrderService(
            new OrderValidator(),
            new PaymentProcessor(),
            new DatabaseController(),
            new OrderEmailSender());
        var order = new Order()
        {            
            Items = ["eggs", "bread", "milk", "yogurt"],
            TotalAmount = 19.96,
            CustomerEmail = customerEmail,
            PaymentMethod = new PayPal()
        };
        orderService.PlaceOrder(order);
    }
}