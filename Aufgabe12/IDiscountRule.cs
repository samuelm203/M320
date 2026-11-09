namespace M320.Aufgabe12;

public interface IDiscountRule
{ 
    string Name { get; }
    
    decimal CalculateDiscount(Book book, Customer customer);
}
