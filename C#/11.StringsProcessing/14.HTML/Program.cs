using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder html = new StringBuilder();

        string title = Console.ReadLine();
        string article = Console.ReadLine();

        html.Append("<h1>").Append(Environment.NewLine);
        html.Append("    ").Append(title).Append(Environment.NewLine);
        html.Append("</h1>").Append(Environment.NewLine);
        html.Append("<article>").Append(Environment.NewLine);
        html.Append("    ").Append(article).Append(Environment.NewLine);
        html.Append("</article>").Append(Environment.NewLine);

        string comment;

        while ((comment = Console.ReadLine()) != "end of comments")
        {
            html.Append("<div>").Append(Environment.NewLine);
            html.Append("    ").Append(comment).Append(Environment.NewLine);
            html.Append("</div>").Append(Environment.NewLine);
        }

        Console.WriteLine(html);
    }
}