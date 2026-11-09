namespace M320.Repetition08;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Aufgabe 1: Klasse extrahieren ===");
        Customer customer = new Customer("Anna Muster", new Address("Bahnhofstrasse 1", "6003", "Luzern"));
        Console.WriteLine($"{customer.Name}: {customer.FullAddress()}");

        Console.WriteLine();
        Console.WriteLine("=== Aufgabe 2: Polymorphismus statt switch ===");
        ShippingCalculator calculator = new ShippingCalculator();
        IShippingCountry[] countries =
        {
            new Germany(),
            new Austria(),
            new Switzerland(),
            new OtherCountry("FR")
        };

        foreach (IShippingCountry country in countries)
            Console.WriteLine($"{country.Code}: {calculator.ShippingCost(country, 100m):F2}");

        Console.WriteLine();
        Console.WriteLine("=== Aufgabe 3: Umbenennen & vereinfachen ===");
        new EvenNumberReport().PrintSumOfEvenNumbersTwice(new List<int> { 1, 2, 3, 4, 5, 6 });
    }
}
