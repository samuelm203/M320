using System;
using System.Collections.Generic;

public class Villain
{
    private readonly List<Henchman> _henchmen = new();

    public string Name { get; init; }
    public Agent? Archenemy { get; set; }
    public List<Henchman> Henchmen => _henchmen;

    public Villain(string name)
    {
        Name = name;
    }

    public void AddHenchman(Henchman henchman)
    {
        _henchmen.Add(henchman);
    }

    public void SendHenchmenOnAgent()
    {
        if (Archenemy == null)
        {
            Console.WriteLine($"{Name} hat noch keinen Erzfeind definiert!");
            return;
        }

        Console.WriteLine($"=== {Name} schickt seine Schergen auf {Archenemy.Name}! ===");

        foreach (Henchman henchman in _henchmen)
        {
            henchman.Attack(Archenemy);
        }

        Console.WriteLine("\n==================================================");
        if (Archenemy.IsIncapacitated)
        {
            Console.WriteLine($"{Name} triumphiert: \"Haha! {Archenemy.Name} ist Geschichte! Die Weltherrschaft gehört mir!\"");
        }
        else
        {
            Console.WriteLine($"{Name} gibt sich geschlagen: \"Verflucht seist du, {Archenemy.Name}! Wir sehen uns wieder!\"");
        }
    }
}