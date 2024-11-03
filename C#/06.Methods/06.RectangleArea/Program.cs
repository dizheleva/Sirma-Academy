
internal class Program
{
    private static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int result = GetRectangleArea(width, height);
        Console.WriteLine(result);
    }

    private static int GetRectangleArea(int width, int height) => width * height;
}