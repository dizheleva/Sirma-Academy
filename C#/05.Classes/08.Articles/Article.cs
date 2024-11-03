
namespace _08.Articles
{
    public class Article
    {
        private string Title { get; set; }
        private string Content { get; set; }
        private string Author { get; set; }

        public Article(string title, string content, string author) 
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newName)
        {
            this.Title = newName;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
