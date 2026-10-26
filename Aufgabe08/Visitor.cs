namespace M320.Aufgabe08;

public class Visitor
{
    public string LastName { get; init; }
    public string FirstName { get; init; }

    public Visitor(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }
}