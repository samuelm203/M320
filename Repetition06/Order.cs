namespace M320.Repetition06;

public class Order
{
    public int Number { get; }
    public Customer Customer { get; }

    public Order(int number, Customer customer)
    {
        Number = number;
        Customer = customer;
    }
}
