namespace M320.Repetition05;

public class Course
{
    public string Title { get; set; }
    public Professor Teacher { get; set; }

    public Course(string title, Professor teacher)
    {
        Title = title;
        Teacher = teacher;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Kurs: {Title}, unterrichtet von {Teacher.Name}");
    }
}
