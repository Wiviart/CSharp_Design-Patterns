class FloppyDisk : Equipment
{
    public FloppyDisk(string name) : base(name)
    {
    }

    public override double NetPrice()
    {
        return 1.0;
    }
}