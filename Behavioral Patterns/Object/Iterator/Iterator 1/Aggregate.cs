abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}

class ConcreteAggregate : Aggregate
{
    private List<Item> items = new List<Item>();

    public override Iterator CreateIterator()
        => new ConcreteIterator(this);

    public int Count => items.Count;

    public Item this[int index]
    {
        get { return items[index]; }
        set { items.Add(value); }
    }
}