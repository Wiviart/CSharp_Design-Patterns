class Maze
{
    List<Room> rooms = new List<Room>();

    public Maze() { }

    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }

    public Room RoomNo(int roomNumber)
    {
        if (roomNumber > rooms.Count || roomNumber < 1)
            return null;

        return rooms[roomNumber - 1];
    }

    public void Enter()
    {
        Console.WriteLine($"Entering maze has {rooms.Count} rooms.");

        foreach (var room in rooms)
        {
            room.Enter();
        }
    }
}