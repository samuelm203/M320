namespace M320.Aufgabe05;

class Program
{
    private static void Main(string[] args)
    {
        Artist daftPunk = new Artist("Daft Punk");
        Artist hansZimmer = new Artist("Hans Zimmer");

        Music song1 = new Music("Electronic", daftPunk, 120);
        Music song2 = new Music("Soundtrack", hansZimmer, 85);
        Music song3 = new Music("House", daftPunk, 128);

        List<Music> myPlaylist = new List<Music> { song1, song2, song3 };

        Human max = new Human("Max Mustermann", 28);
        max.Speak();

        Console.WriteLine($"Hat Max ein Haustier? {(max.HasAnimal() ? "Ja" : "Nein")}");

        Animal hund = new Animal("Hund (Golden Retriever)");
        max.Pet = hund;
        Console.WriteLine("Max hat gerade einen Hund adoptiert!");

        if (max.HasAnimal())
        {
            Console.WriteLine($"Hat Max jetzt ein Haustier? Ja!");
            max.Pet.MakeSound(); 
        }

        max.ListenTo(myPlaylist);
        
        Console.WriteLine("");
    }
}