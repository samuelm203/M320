namespace M320.Repetition08;

public class ShippingCalculator
{
    public decimal ShippingCost(IShippingCountry country, decimal orderValue)
    {
        return country.ShippingCost(orderValue);
    }
}
