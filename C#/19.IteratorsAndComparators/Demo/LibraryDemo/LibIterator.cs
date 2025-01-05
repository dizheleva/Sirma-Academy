namespace Demo.LibraryDemo
{
    using System.Collections;

    public class LibIterator : IEnumerator<Book>
    {
        private int currentIndex = -1;
        private List<Book> books;

        public LibIterator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => books[currentIndex];

        public void Dispose() => books.Clear();

        public bool MoveNext()
        {
            if (currentIndex < books.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public void Reset() => currentIndex = -1;
    }
}
