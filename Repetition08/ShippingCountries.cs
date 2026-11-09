namespace M320.Repetition08;

public class Germany : IShippingCountry
{
    public string Code => "DE";

    public decimal ShippingCost(decimal orderValue) => 5m;
}

public class Austria : IShippingCountry
{
    public string Code => "AT";

    public decimal ShippingCost(decimal orderValue) => 6m;
}

public class Switzerland : IShippingCountry
{
    public string Code => "CH";

    public decimal ShippingCost(decimal orderValue) => 10m;
}

public class OtherCountry : IShippingCountry
{
    public OtherCountry(string code)
    {
        Code = code;
    }

    public string Code { get; }

    public decimal ShippingCost(decimal orderValue) => 15m;
}
