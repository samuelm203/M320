using System;

public class Henchman
{
    protected int _damage;
    protected int _hitpoints;

    public string Name { get; init; }

    public Henchman(string name)
    {
        Name = name;
    }

    public virtual void Attack(Agent agent)
    {
        Console.WriteLine($"\n[{GetType().Name}] {Name} (HP: {_hitpoints}, DMG: {_damage}) greift {agent.Name} an!");
        agent.GetHit(_damage);
        _hitpoints -= agent.Attack();
        Console.WriteLine($"[{GetType().Name}] {Name} hat noch {Math.Max(0, _hitpoints)} HP.");
    }
}

public class Killer : Henchman
{
    public Killer(string name) : base(name)
    {
        _damage = 10;
        _hitpoints = 5;
    }
}

public class Thug : Henchman
{
    public Thug(string name) : base(name)
    {
        _damage = 1;
        _hitpoints = 5;
    }

    public override void Attack(Agent agent)
    {
        Console.WriteLine($"\n[Thug] {Name} stürzt sich auf {agent.Name} und kämpft bis zum Umfallen!");
        while (_hitpoints > 0)
        {
            agent.GetHit(_damage);
            _hitpoints -= agent.Attack();
            Console.WriteLine($"[Thug] {Name} hat noch {Math.Max(0, _hitpoints)} HP.");
        }
        Console.WriteLine($"[Thug] {Name} geht zu Boden!");
    }
}

public class Hacker : Henchman
{
    public Hacker(string name) : base(name)
    {
        _damage = 0;
        _hitpoints = 2;
    }

    public override void Attack(Agent agent)
    {
        Console.WriteLine($"\n[Hacker] {Name} hackt die Ausrüstung von {agent.Name}!");
        agent.ReduceDamage(1);
        _hitpoints -= agent.Attack();
        Console.WriteLine($"[Hacker] {Name} hat noch {Math.Max(0, _hitpoints)} HP.");
    }
}