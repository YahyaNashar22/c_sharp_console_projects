public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book( "Book1", 1),
            new Book( "Book2", 2),
            new Book( "Book3", 3),
            new Book( "Book4", 4),
        };
    }
}