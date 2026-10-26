namespace M320.Aufgabe08;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Museum museum = new Museum("Kunstmuseum Luzern");
        Console.WriteLine($"Museum erstellt: {museum.Name}\n");

        museum.AddRoom("Saal 1; Jugendstil");
        museum.AddRoom("Saal 2; Impressionismus");
        Console.WriteLine("Räume 'Saal 1; Jugendstil' und 'Saal 2; Impressionismus wurden hinzugefügt.\n");

        Visitor visitorOne = new Visitor("Kunz", "Richard");
        Visitor visitorTwo = new Visitor("Ettlin", "Neville");

        museum.AddVisitor(visitorOne);
        museum.AddVisitor(visitorTwo);

        Console.WriteLine("Aktuelle Besucher im Museum:");
        foreach (Visitor visitor in museum.Visitors)
        {
            Console.WriteLine($"- {visitor.FirstName} {visitor.LastName}");
        }

        museum.RemoveVisitor(visitorOne);
        Console.WriteLine($"{visitorOne.FirstName} {visitorOne.LastName} hat das Museum verlassen.");
        Console.WriteLine($"Verbleibende Besucheranzahl: {museum.Visitors.Count}\n");

        Exhibit exhibitDerKuss = new Exhibit("Der Kuss");
        Exhibit exhibitSternennacht = new Exhibit("Sternennacht");
        Exhibit exhibitLeDéfenseur = new Exhibit("Le Défenseur");

        Console.WriteLine("\nVor der Zuweisung:");
        Console.WriteLine($"'{exhibitDerKuss.Label}' ist in Raum: {(exhibitDerKuss.Location?.RoomLabel ?? "Lager")}");
        Console.WriteLine($"'{exhibitSternennacht.Label}' ist in Raum: {(exhibitSternennacht.Location?.RoomLabel ?? "Lager")}");
        Console.WriteLine($"'{exhibitLeDéfenseur.Label}' ist in Raum: {(exhibitLeDéfenseur.Location?.RoomLabel ?? "Lager")}");

        
        museum.PutExhibitInRoom(exhibitDerKuss, "Saal 1; Jugendstil");
        museum.PutExhibitInRoom(exhibitSternennacht, "Saal 2; Impressionismus");

        Console.WriteLine("\nNach der Zuweisung:");
        Console.WriteLine($"- '{exhibitDerKuss.Label}' steht jetzt in: {(exhibitDerKuss.Location?.RoomLabel ?? "Lager")}");
        Console.WriteLine($"- '{exhibitSternennacht.Label}' steht jetzt in: {(exhibitSternennacht.Location?.RoomLabel ?? "Lager")}");
        Console.WriteLine($"- '{exhibitLeDéfenseur.Label}' steht jetzt in: {(exhibitLeDéfenseur.Location?.RoomLabel ?? "Lager")}");
    }
}