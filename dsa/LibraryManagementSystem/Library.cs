public class Library
{
    private List<Book> Books;
    public Library()
    {
        Books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added Book: {book.Title}");
    }
    private Book FindBookByTitle(string title)
    {
        return Books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
    private Book FindBookByISBN(string isbn)
    {
        return Books.Find(book => book.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
    }
    public bool CheckOut(string title)
    {
        Book book = FindBookByTitle(title);
        if (book != null)
        {
            if (book.CheckOut())
            {
                Console.WriteLine($"Successfully checked out: {book.Title}");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, {book.Title} is not available.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Book not found");
            return false;
        }
    }
    public bool ReturnBook(string title)
    {
        Book book = FindBookByTitle(title);
        if(book !=  null)
        {
            if(book.ReturnBook())
            {
                Console.WriteLine($"Successfully returned: {book.Title}");
                return true;
            }
            else
            {
                Console.WriteLine($"Error: Unable to return {book.Title}. Something went wrong.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Book not found.");
            return false;
        }
    }

    public void DisplayAllBooks()
    {
        if(Books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
            return;
        }
        foreach(Book book in Books)
        {
            Console.WriteLine(book.TurnToString());
        }
    }

    public void DisplayAvailableBooks()
    {
        var availableBooks = Books.FindAll(book => book.AvailableCopies > 0);
        if(availableBooks.Count == 0)
        {
            Console.WriteLine("No books are currently available.");
            return;
        }
        foreach(Book book in Books)
        {
            Console.WriteLine(book.TurnToString());
        }
    }
}