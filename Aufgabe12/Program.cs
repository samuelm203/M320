using System.Globalization;

namespace M320.Aufgabe12;

public class Program
{

    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("de-CH");

        Book cleanCode = new PhysicalBook("Clean Code", "978-0132350884", 25.00m, 680);
        Book pragmatic = new EBook("The Pragmatic Programmer", "978-0135957059", 34.00m, 12.5);
        Book patterns = new PhysicalBook("Design Patterns", "978-0201633610", 48.00m, 950);

        Customer anna = new Customer("Anna Muster", "anna@example.ch", false);
        Order order1 = anna.PlaceOrder(new[] { cleanCode, pragmatic });
        order1.AddDiscountRule(new MemberDiscount());
        order1.AddDiscountRule(new EbookDiscount());
        order1.PrintInvoice();

        Customer ben = new Customer("Ben Beispiel", "ben@buchclub.ch", true);
        Order order2 = ben.PlaceOrder(new[] { cleanCode, pragmatic, patterns });
        order2.AddDiscountRule(new MemberDiscount());
        order2.AddDiscountRule(new EbookDiscount());
        order2.PrintInvoice();

        Order order3 = ben.PlaceOrder(new[] { patterns });
        order3.AddDiscountRule(new NoDiscount());
        order3.PrintInvoice();

        foreach (string email in new[] { "keinAt.ch", "@example.ch", "a@b@c.ch", "max@domain" })
        {
            try
            {
                new Customer("Test", email, false);
                Console.WriteLine($"'{email}' wurde fälschlicherweise akzeptiert!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Abgelehnt: {ex.Message.Split(" (Parameter")[0]}");
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"Book ist abstrakt und nicht direkt erzeugbar: {typeof(Book).IsAbstract}");
    }
}
