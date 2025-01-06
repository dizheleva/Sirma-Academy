using _02.OpenClosedPrinciple;

internal class Program
{
    private static void Main(string[] args)
    {
        var service = new DiscountService();

        var amount = 100.0;
        var discountType = "Student";
        var discountedAmount = service.CalculateDiscount(discountType, amount);
        
        Console.WriteLine($"Amount: {amount}, After {discountType} Discount: {discountedAmount}");
    }
}