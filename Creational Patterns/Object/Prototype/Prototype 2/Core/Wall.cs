class Wall : MapSite
{
    public Wall() { }
    public override void Enter()
    {
        Console.WriteLine("Wall.Enter");
    }
    public virtual Wall Clone() => new Wall();
}