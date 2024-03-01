class FlyweightFactory
{
    private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
    public Flyweight GetFlyweight(string key)
    {
        if (!flyweights.ContainsKey(key))
        {
            flyweights[key] = new ConcreteFlyweight();
        }
        return flyweights[key];
    }

    public UnsharedConcreteFlyweight GetUnsharedFlyweight(int intrinsicState)
    {
        return new UnsharedConcreteFlyweight(intrinsicState);
    }
}