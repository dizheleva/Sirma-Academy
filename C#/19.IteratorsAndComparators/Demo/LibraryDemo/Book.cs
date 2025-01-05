namespace Demo.LibraryDemo
{
    using System.Collections.Generic;

    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            SetTitle(title);
            SetYear(year);
            SetAuthors(authors);
        }

        private void SetTitle(string title)
        {
            this.title = title;
        }

        private void SetYear(int year)
        {
            this.year = year;
        }

        private void SetAuthors(params string[] authors)
        {
            if (authors.Length == 0)
            {
                this.authors = new List<string>();
            }
            else
            {
                this.authors = new List<string>(authors);
            }
        }

        public string GetTitle() => title;

        public int GetYear() => year;

        public List<string> GetAuthors() => authors;

        public int CompareTo(Book? other)
        {
            var xYear = GetYear();
            var yYear = other.GetYear();

            var xTitle = GetTitle();
            var yTitle = other.GetTitle();

            var result = xYear.CompareTo(yYear);

            if (result == 0)
            {
                result = xTitle.CompareTo(yTitle);
            }

            return result;
        }
    }
}
