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
