namespace M320.Repetition05;

public class Book
{
    public string Title { get; }
    public Library? CurrentLibrary { get; internal set; }

    public Book(string title)
    {
        Title = title;
    }

    public void TransferTo(Library destination)
    {
        CurrentLibrary?.RemoveBook(this);
        destination.AddBook(this);
    }
}
