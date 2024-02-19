class EnchantedMazeFactory : MazeFactory
{
    public EnchantedMazeFactory() { }
    public override Room MakeRoom(int n) => new EnchantedRoom(n, CastSpell());
    public override Door MakeDoor(Room r1, Room r2) => new DoorNeedingSpell(r1, r2);
    protected Spell CastSpell()
    {
        return new Spell();
    }
}