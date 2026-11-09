namespace M320.Aufgabe12;

public class PhysicalBook : Book
{
    private const decimal ShippingCost = 2.00m;

    private int weightInGrams;

    public PhysicalBook(string title, string isbn, decimal basePrice, int weightInGrams)
        : base(title, isbn, basePrice)
    {
        if (weightInGrams <= 0)
            throw new ArgumentOutOfRangeException(nameof(weightInGrams), "Das Gewicht muss grösser als 0 sein.");

        this.weightInGrams = weightInGrams;
    }
    
    public int WeightInGrams => weightInGrams;
    
    public override decimal GetPrice()
    {
        return basePrice + ShippingCost;
    }

    public override string GetTypeName()
    {
        return "Physisches Buch";
    }
}
