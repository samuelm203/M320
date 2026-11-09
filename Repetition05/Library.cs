namespace M320.Repetition05;

public class Library
{
    private readonly List<Book> _books = new();

    public string Name { get; }
    public IReadOnlyList<Book> Books => _books;

    public Library(string name)
    {
        Name = name;
    }

    public void AddBook(Book book)
    {
        if (book.CurrentLibrary == this)
            return;

        book.CurrentLibrary?.RemoveBook(book);
        _books.Add(book);
        book.CurrentLibrary = this;
    }

    internal void RemoveBook(Book book)
    {
        if (_books.Remove(book))
            book.CurrentLibrary = null;
    }

    public void PrintInventory()
    {
        Console.WriteLine($"Bibliothek {Name} ({_books.Count} Bücher):");
        if (_books.Count == 0)
            Console.WriteLine("  (leer)");

        foreach (Book book in _books)
            Console.WriteLine($"  - {book.Title}");
    }
}
