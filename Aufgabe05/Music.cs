namespace M320.Aufgabe05;

public class Music
{
    private string _genre;
    private Artist _artist;

    public int Tempo { get; set; }

    public Music(string genre, Artist artist, int tempo)
    {
        _genre = genre;
        _artist = artist;
        Tempo = tempo;
    }

    public void Play()
    {
        Console.WriteLine($"   -> Spiele {_genre}-Track von {_artist} mit {Tempo} BPM...");
    }
}