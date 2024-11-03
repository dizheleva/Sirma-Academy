
internal class Program
{
    private static Queue<int> fibonacci = new Queue<int>([0, 1, 1]);
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int result = GetFibonacci(n);
        Console.WriteLine(result);
        Console.WriteLine(string.Join(" ", fibonacci.ToArray()));
    }

    private static int GetFibonacci(int n)
    {
        //fibonacci.Enqueue(1);
        if (n <= 2)
        {            
            return 1;
        }

        int curr = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        if (!fibonacci.Contains(curr))
        {
            fibonacci.Enqueue(curr);
        }
        
        return curr;
    }
}