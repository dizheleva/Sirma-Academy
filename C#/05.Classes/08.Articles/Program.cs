using _08.Articles;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] articleArgs = Console.ReadLine().Split(", ");
        Article article = new Article(articleArgs[0], articleArgs[1], articleArgs[2]);

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] commandLine = Console.ReadLine().Split(": ");
            string command = commandLine[0];
            string newData = commandLine[1];

            switch (command)
            {
                case "Edit":
                    article.Edit(newData);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(newData);
                    break;
                case "Rename":
                    article.Rename(newData);
                    break;
            }
        }

        Console.WriteLine(article.ToString());
    }
}