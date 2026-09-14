namespace M320.Aufgabe05;

public class Animal
{
    private string _species;

    public Animal(string species)
    {
        _species = species;
    }

    public void MakeSound()
    {
        Console.WriteLine($"Das {_species} macht: Wuff");
    }
}