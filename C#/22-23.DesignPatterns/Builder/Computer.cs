namespace Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string PowerSupply { get; set; }
        public string Motherboard { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Custom PC configuration:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"Power Supply: {PowerSupply}");
            Console.WriteLine($"Motherboard: {Motherboard}");
        }
    }
}
