namespace M320.Aufgabe05;

public class Artist
{
    private string _name;

    public Artist(string name)
    {
        _name = name;
    }

    public override string ToString()
    {
        return _name;
    }
}