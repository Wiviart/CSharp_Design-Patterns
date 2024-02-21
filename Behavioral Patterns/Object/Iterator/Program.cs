class Item
{
    private string _name = "";
    public string Name
    {
        set { _name = value; }
        get { return _name; }
    }
}

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

abstract class Iterator
{
    public abstract Item First();
    public abstract Item Next();
    public abstract Item CurrentItem();
    public abstract bool IsDone();
}

class ConcreteIterator : Iterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate agg)
    {
        aggregate = agg;
    }

    public override Item First()
    {
        current = 0;
        return CurrentItem();
    }

    public override Item Next()
    {
        current++;

        if (!IsDone())
            return CurrentItem();

        return null;
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }

    public override Item CurrentItem()
    {
        return aggregate[current];
    }
}

class Client
{
    static void Main()
    {
        ConcreteAggregate a = new ConcreteAggregate();
        a[0] = new Item { Name = "Item 0" };
        a[1] = new Item { Name = "Item 1" };
        a[2] = new Item { Name = "Item 2" };
        a[3] = new Item { Name = "Item 3" };

        Iterator i = a.CreateIterator();

        Console.WriteLine("Iterating over collection:");

        while (!i.IsDone())
        {
            Console.WriteLine(i.CurrentItem().Name);
            i.Next();
        }
    }
}
