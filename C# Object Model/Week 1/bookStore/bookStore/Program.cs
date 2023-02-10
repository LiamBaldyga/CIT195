using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetId(1);
            book1.SetTitle("The Hobbit");
            book1.SetAuthor("J.R.R. Tolkien");

            Book book2 = new Book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book2.SetAuthor(Console.ReadLine());

            Book book3 = new Book(3, "Dune", "Frank Herbert");

            Console.WriteLine("Please enter the book ID: ");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempId, tempTitle, tempAuthor);


            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }
        
        static void displayBooks(Book book)
        {
            Console.WriteLine("Here is the book information");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
            Console.WriteLine($"Book ID: {book.GetId()}");
        }


    }
}

class Book
{
    private int _Id;
    private string _Title;
    private string _Author;

    public Book()
    {
        _Id = 0;
        _Title = "";
        _Author = "";
    }

    public Book(int id, string title, string author)
    {
        _Id = id;
        _Title = title;
        _Author = author;
    }

    public int GetId()
    {
        return _Id;
    }

    public void SetId(int id)
    {
        _Id = id;
    }

    public string GetTitle()
    {
        return _Title;
    }

    public void SetTitle(string title)
    {
        _Title = title;
    }

    public string GetAuthor()
    {
        return _Author;
    }
    
    public void SetAuthor(string author)
    {
        _Author = author;
    }
}