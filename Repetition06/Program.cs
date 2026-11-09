namespace M320.Repetition06;

public class Program
{
    public static void Main(string[] args)
    {
        Customer anna = new Customer("Anna");
        Order[] orders =
        {
            new Order(1, anna),
            new Order(2, anna),
            new Order(3, new Customer("Ben"))
        };

        foreach (Order order in orders)
            Console.WriteLine($"Bestellung {order.Number} gehört zu {order.Customer.Name}");
    }
}
