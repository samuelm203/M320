namespace M320.Repetition08;

public interface IShippingCountry
{
    string Code { get; }

    decimal ShippingCost(decimal orderValue);
}
