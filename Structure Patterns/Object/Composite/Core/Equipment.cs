abstract class Equipment
{
    private string name;
    public string Name => name;

    protected Equipment(string name)
    {
        this.name = name;
    }

    public virtual double NetPrice() { return 0; }
    public virtual void Add(Equipment equipment) { }
    public virtual void Remove(Equipment equipment) { }
    public virtual Equipment? GetChild(int index) => null;
}