namespace _06.FindViolations.Task7
{
    public class PhysicalBookRepository : IBookRepository
    {
        private List<PhysicalBook> _books;

        public PhysicalBookRepository(List<PhysicalBook> books)
        {
            _books = books;
        }

        public void TakeBook(string title)
        {
            if (_books.Any(b => b.Title == title))
            {
                _books.First(b => b.Title == title).BorrowedCount++;
                Console.WriteLine($"Physical book borrowed: {title}");
            }
        }
    }
}
