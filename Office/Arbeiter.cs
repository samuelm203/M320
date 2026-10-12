public abstract class Arbeiter
    {
        public string Name { get; set; }

        public Arbeiter(string name)
        {
            Name = name;
        }

        // Abstrakte Methode (kein Rumpf). Zwingt alle erbenden Klassen, das zu implementieren.
        public abstract void MacheTagesabschluss();

        // Virtuelle Methode (hat einen Rumpf, KANN überschrieben werden)
        public virtual void Arbeite()
        {
            Console.WriteLine($"{Name} erledigt allgemeine Papierarbeit.");
        }

        // Normale Methode (soll eigentlich so bleiben)
        public void MachePause()
        {
            Console.WriteLine($"{Name} trinkt Kaffee im Pausenraum.");
        }
    }

    // 2. ABGELEITETE KLASSE: Verkäufer ("ist ein" Arbeiter)
    public class Verkaeufer : Arbeiter
    {
        public Verkaeufer(string name) : base(name) { }

        // MUSS überschrieben werden, da in Basisklasse 'abstract'
        public override void MacheTagesabschluss()
        {
            Console.WriteLine($"{Name} trägt die Verkaufszahlen in die Excel-Liste ein.");
        }

        // Polymorphes Überschreiben der virtuellen Methode
        public override void Arbeite()
        {
            Console.WriteLine($"{Name} ruft Kunden an und verkauft Papier.");
        }
    }

    // 3. ABGELEITETE KLASSE: Manager ("ist ein" Arbeiter)
    public class Manager : Arbeiter
    {
        public Manager(string name) : base(name) { }

        // MUSS überschrieben werden
        public override void MacheTagesabschluss()
        {
            Console.WriteLine($"{Name} delegiert den Tagesabschluss an Pam.");
        }

        // Polymorphes Überschreiben
        public override void Arbeite()
        {
            Console.WriteLine($"{Name} hält ein zweistündiges Meeting ohne Agenda.");
        }

        // STOLPERFALLE (new): Verdeckt die Pause-Methode der Basisklasse, 
        // statt sie sicher zu überschreiben.
        public new void MachePause()
        {
            Console.WriteLine($"{Name} isst eine Familienpizza allein im Büro.");
        }
    }