namespace M320.Aufgabe05;

public class Human
{
    private string _name;
    private int _age;

    public Animal? Pet { get; set; }

    public Human(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public void Speak()
    {
        Console.WriteLine($"Hallo! Mein Name ist {_name} und ich bin {_age} Jahre alt.");
    }

    public void ListenTo(IEnumerable<Music> playlist)
    {
        Console.WriteLine($"{_name} startet die Playlist:");
        foreach (var song in playlist)
        {
            song.Play(); 
        }
    }

    public bool HasAnimal()
    {
        return Pet != null;
    }
}