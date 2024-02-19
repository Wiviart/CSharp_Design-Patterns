class Door : MapSite
{
    private Room _room1;
    private Room _room2;
    private bool _isOpen;

    public Door(Room room1, Room room2)
    {
        _room1 = room1;
        _room2 = room2;
        Random Random = new Random();
        _isOpen = Random.Next(2) == 1;
    }
    
    public override void Enter()
    {
        Console.WriteLine($"Door between room {_room1} and room {_room2} can be enter: {_isOpen}");
    }
}