namespace Demo.LibraryDemo
{
    using System.Collections;

    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {
            for (var i = 0; i < books.Count - 1; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => new LibIterator(books);
    }
}
