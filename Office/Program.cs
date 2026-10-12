namespace M320.Office;

public class Program
{
    public static void Main(string[] args)
    {
        // Arbeiter a = new Arbeiter("Unbekannt"); 
        // -> FEHLER: Abstrakte Klassen können nicht instanziiert werden.

        Verkaeufer jim = new Verkaeufer("Jim");
        Manager michael = new Manager("Michael");

        // Wir packen Michael in eine Variable vom Typ der BASISKLASSE.
        // Das passiert oft, wenn man z.B. eine List<Arbeiter> durchgeht.
        Arbeiter gMichael = michael;

        Console.WriteLine("--- Test 1: MacheTagesabschluss (abstract) ---");
        jim.MacheTagesabschluss();
        michael.MacheTagesabschluss();

        Console.WriteLine("\n--- Test 2: Arbeite (virtual / override) ---");
        // Polymorphismus funktioniert: Obwohl die Variable 'getarnterMichael' 
        // vom Typ Arbeiter ist, weiß das Programm, dass es ein Manager ist.
        gMichael.Arbeite(); // Ausgabe: ...hält ein zweistündiges Meeting...

        Console.WriteLine("\n--- Test 3: MachePause (Die 'new' Stolperfalle) ---");
        // Wenn wir Michael direkt als Manager ansprechen:
        michael.MachePause(); // Ausgabe: ...isst eine Familienpizza... (Verdeckte Methode greift)
            
        // Wenn wir Michael über die Basisklasse ansprechen (die Stolperfalle schlägt zu):
        gMichael.MachePause(); // Ausgabe: ...trinkt Kaffee im Pausenraum. (Basis-Methode greift!)    
    }
}