namespace M320.Aufgabe12;

public class Order
{
    private static int nextOrderNumber = 1001;

    private int orderNumber;
    private DateTime orderDate;
    private Customer customer;
    private List<Book> books;
    private List<IDiscountRule> discountRules = new();
    
    public Order(Customer customer, Book[] books)
    {
        ArgumentNullException.ThrowIfNull(customer);
        ArgumentNullException.ThrowIfNull(books);
        if (books.Length == 0)
            throw new ArgumentException("Eine Bestellung braucht mindestens ein Buch.", nameof(books));

        this.customer = customer;
        this.books = new List<Book>(books);
        orderDate = DateTime.Now;
        orderNumber = nextOrderNumber++;
    }
    public int OrderNumber => orderNumber;
    
    public DateTime OrderDate => orderDate;
    
    public Customer Customer => customer;

    public IReadOnlyList<Book> Books => books.AsReadOnly();
    
    public void AddDiscountRule(IDiscountRule rule)
    {
        ArgumentNullException.ThrowIfNull(rule);
        discountRules.Add(rule);
    }
    
    public decimal GetDiscount(Book book)
    {
        decimal best = 0m;
        foreach (IDiscountRule rule in discountRules)
        {
            decimal discount = rule.CalculateDiscount(book, customer);
            if (discount > best)
                best = discount;
        }
        
        return Math.Min(best, book.GetPrice());
    }

    public decimal GetTotal()
    {
        decimal total = 0m;
        foreach (Book book in books)
        {
            total += book.GetPrice() - GetDiscount(book);
        }
        return total;
    }
    
    public void PrintInvoice()
    {
        string member = customer.IsMember ? "Mitglied" : "kein Mitglied";
        Console.WriteLine($"Bestellung #{orderNumber} vom {orderDate:dd.MM.yyyy HH:mm}");
        Console.WriteLine($"Kunde: {customer.Name} <{customer.Email}> ({member})");
        Console.WriteLine(new string('-', 50));

        foreach (Book book in books)
        {
            Console.WriteLine($"{book.Title} [{book.GetTypeName()}]");
            Console.WriteLine($"   Preis:  {book.GetPrice(),8:F2} CHF");

            decimal discount = GetDiscount(book);
            if (discount > 0)
                Console.WriteLine($"   Rabatt: {-discount,8:F2} CHF");
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Total:     {GetTotal(),8:F2} CHF");
        Console.WriteLine();
    }
}
