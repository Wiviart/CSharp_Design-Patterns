class Room : MapSite
{
    public Room() { }

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

    private MapSite[] _sides = new MapSite[4];

    public Room Clone() => new Room();

}