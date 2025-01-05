namespace _01.SingleResponsibilityPrinciple
{
    using System;

    public class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
                
        public string GetBookSummary()
        {
            return $"{this.Title} by {this.Author}";
        }
    }
}
