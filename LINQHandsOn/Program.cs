class Program
{
    static void Main(string[] args)
    {
        var books = new BookRepository().GetBooks();

        Console.WriteLine("---------First syntax---------");

        var cheapBooks = books.Where(book => book.Price < 3).OrderBy(book => book.Title).Select(book => book.Title);

        foreach (var book in cheapBooks)
        {
            Console.WriteLine();
            Console.WriteLine($"book: {book}");
            Console.WriteLine();
        }

        Console.WriteLine("---------Second syntax---------");

        var cheapBooks2 = from book in books
                          where book.Price < 3
                          orderby book.Title
                          select book;

        foreach (var book in cheapBooks2)
        {
            Console.WriteLine();
            Console.WriteLine($"book: {book.Title}");
            Console.WriteLine();
        }

        Console.WriteLine("---------Third syntax---------");
        var result = books.SingleOrDefault(book => book.Title == "Modified Book");
        Console.WriteLine(result != null ? result.Title : "Book not found");

        Console.WriteLine("\nOf course there are many more methods to use but we will not go through them all here duh!\n");
    }
}