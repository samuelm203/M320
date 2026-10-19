namespace M320.Aufgabe08;

using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Museum erstellen
        Museum museum = new Museum("Kunstmuseum Luzern");
        Console.WriteLine($"Museum erstellt: {museum.Name}\n");

        // 2. Räume hinzufügen (Komposition: nur der Name wird übergeben)
        museum.AddRoom("Saal 1 - Renaissance");
        museum.AddRoom("Saal 2 - Moderne");
        Console.WriteLine("Räume 'Saal 1 - Renaissance' und 'Saal 2 - Moderne' wurden hinzugefügt.\n");

        // 3. Besucher erstellen und hinzufügen (Aggregation: Objekte entstehen ausserhalb)
        Visitor v1 = new Visitor("Muster", "Max");
        Visitor v2 = new Visitor("Meier", "Anna");

        museum.AddVisitor(v1);
        museum.AddVisitor(v2);

        Console.WriteLine("Aktuelle Besucher im Museum:");
        foreach (Visitor v in museum.Visitors)
        {
            Console.WriteLine($"- {v.FirstName} {v.LastName}");
        }

        // 4. Einen Besucher wieder entfernen
        museum.RemoveVisitor(v1);
        Console.WriteLine($"\n{v1.FirstName} {v1.LastName} hat das Museum verlassen.");
        Console.WriteLine($"Verbleibende Besucheranzahl: {museum.Visitors.Count}\n");

        // 5. Ausstellungsstücke (Exhibits) erstellen (Aggregation: existieren zuerst auch ohne Raum)
        Exhibit e1 = new Exhibit("Mona Lisa");
        Exhibit e2 = new Exhibit("Sternennacht");

        Console.WriteLine($"Vor der Zuweisung -> '{e1.Label}' ist in Raum: {(e1.Location?.RoomLabel ?? "Keinem Raum (Lager)")}");

        // 6. Ausstellungsstücke in die Räume stellen
        museum.PutExhibitInRoom(e1, "Saal 1 - Renaissance");
        museum.PutExhibitInRoom(e2, "Saal 2 - Moderne");

        Console.WriteLine("\nNach der Zuweisung:");
        Console.WriteLine($"- '{e1.Label}' steht jetzt in: {e1.Location?.RoomLabel}");
        Console.WriteLine($"- '{e2.Label}' steht jetzt in: {e2.Location?.RoomLabel}");
    }
}