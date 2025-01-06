namespace _06.FindViolations.Task7
{
    public class EbookRepository : IBookRepository
    {
        private List<Ebook> _ebooks;

        public EbookRepository(List<Ebook> books)
        {
            _ebooks = books;
        }
        
        public void TakeBook(string title)
        {
            if (_ebooks.Any(b => b.Title == title))
            {
                _ebooks.First(b => b.Title == title).DownloadCount++;
                Console.WriteLine($"Ebook downloaded: {title}");
            }
        }
    }
}
