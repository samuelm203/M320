namespace M320.Repetition05;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Aufgabe 1: Lehrperson und Kurse ===");
        Professor professor = new Professor("Dr. Müller");
        Course oop = new Course("Objektorientierte Programmierung", professor);
        Course databases = new Course("Datenbanken", professor);

        oop.PrintInfo();
        databases.PrintInfo();

        oop.Teacher.Name = "Prof. Dr. Müller";
        oop.PrintInfo();
        databases.PrintInfo();

        Console.WriteLine();
        Console.WriteLine("=== Aufgabe 2: Bibliothek und Bücher ===");
        Library central = new Library("Zentralbibliothek");
        Library school = new Library("Schulbibliothek");

        Book cleanCode = new Book("Clean Code");
        Book refactoring = new Book("Refactoring");
        central.AddBook(cleanCode);
        central.AddBook(refactoring);

        Console.WriteLine("Vor der Verschiebung:");
        central.PrintInventory();
        school.PrintInventory();

        cleanCode.TransferTo(school);

        Console.WriteLine("Nach der Verschiebung:");
        central.PrintInventory();
        school.PrintInventory();
        Console.WriteLine($"'{cleanCode.Title}' gehört zu: {cleanCode.CurrentLibrary?.Name}");

        Console.WriteLine();
        Console.WriteLine("=== Aufgabe 3: Aggregation statt Komposition ===");
        Engine engine = new Engine(150);
        Car car = new Car(engine);
        Console.WriteLine($"Auto hat Motor mit {car.Engine.HorsePower} PS");

        Engine oldEngine = car.ReplaceEngine(new Engine(200));
        Console.WriteLine($"Neuer Motor: {car.Engine.HorsePower} PS, alter Motor existiert weiter: {oldEngine.HorsePower} PS");
    }
}
