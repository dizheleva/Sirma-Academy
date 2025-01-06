namespace _06.FindViolations.Task7
{
    public class LibraryService
    {
        private PhysicalBookRepository _physicalBookRepository;

        private EbookRepository _ebookRepository;

        public LibraryService(PhysicalBookRepository physicalBookRepository, EbookRepository ebookRepository)
        {
            _physicalBookRepository = physicalBookRepository;
            _ebookRepository = ebookRepository;
        }
        public void BorrowBook(IBookRepository repository, string title)
        {
            repository.TakeBook(title);
        }
    }
}
