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