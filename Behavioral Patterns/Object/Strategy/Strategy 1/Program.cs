class Context
{
    private IStrategy strategy;
    public Context(IStrategy strategy)
    {
        this.strategy = strategy;
    }
    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}

interface IStrategy
{
    void AlgorithmInterface();
}

class ConcreteStrategyA : IStrategy
{
    public void AlgorithmInterface()
    {
        Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
    }
}

class ConcreteStrategyB : IStrategy
{
    public void AlgorithmInterface()
    {
        Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
    }
}

class Program
{
    static void Main()
    {
        Context context;
        context = new Context(new ConcreteStrategyA());
        context.ContextInterface();
        context = new Context(new ConcreteStrategyB());
        context.ContextInterface();
    }
}