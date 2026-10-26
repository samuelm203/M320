using System;

public class Agent
{
    private int _damage = 3;
    private int _hitpoints = 20;

    public string Name { get; init; }
    public bool IsIncapacitated => _hitpoints <= 0;

    public Agent(string name)
    {
        Name = name;
    }

    public void GetHit(int damage)
    {
        _hitpoints -= damage;
        Console.WriteLine($"  -> Agent {Name} erleidet {damage} Schaden (Verbleibende HP: {Math.Max(0, _hitpoints)}).");
    }

    public int Attack()
    {
        Console.WriteLine($"  <- Agent {Name} schlägt mit {_damage} Schaden zurück!");
        return _damage;
    }

    public void ReduceDamage(int reduction)
    {
        _damage = Math.Max(0, _damage - reduction);
        Console.WriteLine($"  -> Der Angriffsschaden von Agent {Name} wurde um {reduction} reduziert (Neuer Schaden: {_damage}).");
    }
}