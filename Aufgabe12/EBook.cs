namespace M320.Aufgabe12;

public class EBook : Book
{
    private double fileSizeMb;
    
    public EBook(string title, string isbn, decimal basePrice, double fileSizeMb)
        : base(title, isbn, basePrice)
    {
        if (fileSizeMb <= 0)
            throw new ArgumentOutOfRangeException(nameof(fileSizeMb), "Die Dateigrösse muss grösser als 0 sein.");

        this.fileSizeMb = fileSizeMb;
    }

    public double FileSizeMb => fileSizeMb;
    
    public override decimal GetPrice()
    {
        return basePrice;
    }
    
    public override string GetTypeName()
    {
        return "E-Book";
    }
}
