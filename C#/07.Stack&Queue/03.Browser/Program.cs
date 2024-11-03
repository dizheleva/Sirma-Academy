internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> browser = new Stack<string>();

        string input;
        while ((input = Console.ReadLine()) != "Home")
        {
            if (input == "back")
            {                
                if (browser.Count <= 1)
                {
                    Console.WriteLine("no previous URLs");
                }
                else
                {
                    browser.Pop();
                    Console.WriteLine(browser.Peek());
                }
            }
            else
            {
                browser.Push(input);
                Console.WriteLine(browser.Peek());
            }
        }
    }
}