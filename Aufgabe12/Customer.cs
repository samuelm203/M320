namespace M320.Aufgabe12;

public class Customer
{
    private string name;
    private string email = "";
    private bool isMember;
    
    public Customer(string name, string email, bool isMember)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Der Name darf nicht leer sein.", nameof(name));

        this.name = name;
        Email = email; 
        this.isMember = isMember;
    }
    public string Name => name;
    
    public string Email
    {
        get => email;
        set
        {
            if (!IsValidEmail(value))
                throw new ArgumentException($"Ungültige E-Mail-Adresse: '{value}'", nameof(Email));
            email = value;
        }
    }

    public bool IsMember => isMember;

    private static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email) || email.Contains(' '))
            return false;

        int at = email.IndexOf('@');
        if (at <= 0 || at != email.LastIndexOf('@'))
            return false;

        string domain = email[(at + 1)..];
        int dot = domain.LastIndexOf('.');
        return dot > 0 && dot < domain.Length - 1;
    }
    
    public Order PlaceOrder(Book[] books)
    {
        return new Order(this, books);
    }
}
