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
        return new Room(roomNumber);
    }
    public void Enter()
    {
        foreach (var room in rooms)
        {
            room.Enter();
        }
    }
}