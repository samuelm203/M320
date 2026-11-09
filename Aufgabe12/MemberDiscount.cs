namespace M320.Aufgabe12;

public class MemberDiscount : IDiscountRule
{
    private const decimal Rate = 0.10m;
    
    public string Name => "Mitgliederrabatt 10%";

    public decimal CalculateDiscount(Book book, Customer customer)
    {
        if (!customer.IsMember)
            return 0m;

        return Math.Round(book.GetPrice() * Rate, 2);
    }
}
