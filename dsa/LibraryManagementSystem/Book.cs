public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int TotalCopies { get; private set; }
    private int _availableCopies;
    public int AvailableCopies
    {
        get { return _availableCopies; }
        private set
        {
            if (value >= 0)
            {
                _availableCopies = value;
            }
            else
            {
                throw new ArgumentException("Available copies cannot be negative");
            }
        }
    }

    public Book(string title, string author, string isbn, int totalCopies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        TotalCopies = totalCopies;  // Set TotalCopies
        AvailableCopies = totalCopies;  // Initially, AvailableCopies = TotalCopies
    }

    public bool CheckOut()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            return true;
        }
        Console.WriteLine($"Sorry, no copies of {Title} are available to check out.");
        return false;
    }

    public bool ReturnBook()
    {
        AvailableCopies++;
        return true;
    }

    // Optional: Override ToString() for better book representation
    public string TurnToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN}) - {AvailableCopies} copies available out of {TotalCopies}";
    }
}
