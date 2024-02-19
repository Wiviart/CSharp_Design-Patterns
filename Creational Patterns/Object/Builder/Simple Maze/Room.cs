class Room : MapSite
{
    private MapSite[] _sides = new MapSite[4];
    private int _roomNumber;
    public int RoomNumber => _roomNumber;

    public Room(int roomNumber)
    {
        _roomNumber = roomNumber;
    }

    public MapSite GetSide(Direction direction)
    {
        return _sides[(int)direction];
    }

    public void SetSide(Direction direction, MapSite mapSite)
    {
        _sides[(int)direction] = mapSite;
    }

    public override void Enter()
    {
        for (int i = 0; i < _sides.Length; i++)
        {
            _sides[i].Enter();
        }
    }
}