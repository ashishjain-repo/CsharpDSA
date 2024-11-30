public class Program
{
    static void Main(string[] args)
    {
        Book newBook1 = new Book("Some String", "Some Author", "isbnf2323", 20);
        Book newBook2 = new Book("Some String 1", "Some Author 2", "isbnf232443", 10);

        Library myLibrary = new Library();
        myLibrary.AddBook(newBook1);
        myLibrary.AddBook(newBook2);

        myLibrary.DisplayAllBooks();

        myLibrary.CheckOut("Some String");
        myLibrary.DisplayAllBooks();
    }
}