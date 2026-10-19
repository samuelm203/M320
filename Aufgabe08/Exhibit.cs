namespace M320.Aufgabe08;

public class Exhibit
{
    public string Label { get; }
    public Room Location { get; set; }

    public Exhibit (string label)
    {
        label = Label; 
    }
}