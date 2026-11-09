namespace M320.Aufgabe12;

public class NoDiscount : IDiscountRule
{
    public string Name => "Kein Rabatt";
    
    public decimal CalculateDiscount(Book book, Customer customer)
    {
        return 0m;
    }
}
