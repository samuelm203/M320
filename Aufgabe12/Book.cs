namespace M320.Aufgabe12;

public abstract class Book
{
    protected string title;

    protected string isbn;

    protected decimal basePrice;
    
    protected Book(string title, string isbn, decimal basePrice)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Der Titel darf nicht leer sein.", nameof(title));
        if (string.IsNullOrWhiteSpace(isbn))
            throw new ArgumentException("Die ISBN darf nicht leer sein.", nameof(isbn));
        if (basePrice < 0)
            throw new ArgumentOutOfRangeException(nameof(basePrice), "Der Grundpreis darf nicht negativ sein.");

        this.title = title;
        this.isbn = isbn;
        this.basePrice = basePrice;
    }

    public string Title => title;
    
    public string Isbn => isbn;

    public decimal BasePrice => basePrice;
    
    public abstract decimal GetPrice();
    
    public abstract string GetTypeName();
}
