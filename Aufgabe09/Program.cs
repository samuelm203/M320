namespace M320.Aufgabe09;

public class Program
{
    public static void Main(string[] args)
    {
        Villain blofeld = new Villain("Blofeld");
        Agent bond = new Agent("James Bond");

        blofeld.Archenemy = bond;
        blofeld.AddHenchman(new Thug("Beisser"));
        blofeld.AddHenchman(new Killer("Xenia"));
        blofeld.AddHenchman(new Hacker("Boris"));

        blofeld.SendHenchmenOnAgent();
    }
}