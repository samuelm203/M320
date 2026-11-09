namespace M320.Repetition08;

public class Address
{
    public string Street { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }

    public Address(string street, string zipCode, string city)
    {
        Street = street;
        ZipCode = zipCode;
        City = city;
    }

    public string FullAddress()
    {
        return $"{Street}, {ZipCode} {City}";
    }
}
