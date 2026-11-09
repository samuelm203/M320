namespace M320.Aufgabe12;

public class EbookDiscount : IDiscountRule
{
    private const decimal Rate = 0.15m;

    public string Name => "E-Book-Aktion 15%";
    
    public decimal CalculateDiscount(Book book, Customer customer)
    {
        if (book is not EBook)
            return 0m;

        return Math.Round(book.GetPrice() * Rate, 2);
    }
}
