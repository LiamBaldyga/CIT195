namespace bookStoreRecord
{
    public record Bookstore(int ID, string Title, string Author, double Price);

    class Program
    {
        static void Main(string[] args)
        {
            Bookstore book1 = new(1, "Hyperion", "Dan Simmons", 8.99);
            Bookstore book2 = new(2, "The Fall of Hyperion", "Dan Simmons", 7.99);
            Bookstore book3 = new(3, "Endymion", "Dan Simmons", 7.99);

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
        }
    }
}