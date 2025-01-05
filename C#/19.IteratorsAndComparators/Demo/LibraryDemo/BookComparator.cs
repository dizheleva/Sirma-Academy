namespace Demo.LibraryDemo
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            var xTitle = x.GetTitle();
            var yTitle = y.GetTitle();

            var xYear = x.GetYear();
            var yYear = y.GetYear();

            var result = xTitle.CompareTo(yTitle);

            if (result == 0)
            {
                result = xYear.CompareTo(yYear);
            }

            return result;
        }
    }
}
