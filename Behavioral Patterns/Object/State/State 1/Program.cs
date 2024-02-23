// Context
class Context
{
    private IState currentState;

    public Context()
    {
        // Set the initial state
        currentState = new ConcreteStateA();
    }

    public void SetState(IState state)
    {
        currentState = state;
    }

    public void Request()
    {
        currentState.Handle(this);
    }
}

// State interface
interface IState
{
    void Handle(Context context);
}

// Concrete State A
class ConcreteStateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Handling request in State A");
        // Transition to State B
        context.SetState(new ConcreteStateB());
    }
}

// Concrete State B
class ConcreteStateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Handling request in State B");
        // Transition back to State A
        context.SetState(new ConcreteStateA());
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Context context = new Context();

        while (true)
        {
            context.Request();
            Thread.Sleep(1000);
        }
    }
}
