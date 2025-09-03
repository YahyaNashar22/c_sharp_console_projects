public class Book
{
    public string Title { get; set; }
    public int Price { get; set; }

    public Book(string title, int price)
    {
        Title = title;
        Price = price;
    }
}