namespace M320.Aufgabe08;

public class Museum
{
    private List<Room> _rooms = new List<Room>();

    public string Name { get; }
    public List<Visitor> Visitors { get; } = new List<Visitor>();

    public Museum (string name)
    {
        Name = name; 
    }

    public void AddVisitor (Visitor visitor)
    {
        Visitors.Add(visitor);
    }

    public void RemoveVisitor(Visitor visitor)
    {
        Visitors.Remove(visitor);
    }

    public void AddRoom(string Roomlabel)
    {
        Room newRoom = new Room(Roomlabel);
        _rooms.Add(newRoom);    
    }

    public void PutExhibitInRoom(Exhibit exhibit, string roomLabel)
    {
        foreach (Room room in _rooms)
        {
            if (room.RoomLabel == roomLabel)
            {
                exhibit.Location = room;
                break; 
            }
        }
    }
}