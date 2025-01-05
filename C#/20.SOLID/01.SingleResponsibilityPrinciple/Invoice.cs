namespace _01.SingleResponsibilityPrinciple
{
    public class Invoice
    {
        public double Amount { get; set; }
        public string CustomerName { get; set; }

        public Invoice(double amount, string customerName)
        {
            this.Amount = amount;
            this.CustomerName = customerName;
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"Client: {this.CustomerName} \nInvoice amount {this.Amount}"); 
        }
    }
}
