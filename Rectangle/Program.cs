namespace M320;

class Program
{
    static void Main_ignorieren(string[] args)
    {
        Rectangle rec = new Rectangle();
        rec.Width = 10;
        rec.Height = 20;
        Console.WriteLine(rec.GetArea());
    }
}