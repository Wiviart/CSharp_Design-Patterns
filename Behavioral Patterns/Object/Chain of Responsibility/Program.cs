public abstract class IHandler
{
    protected IHandler? successor;
    public IHandler? Successor => successor;
    public virtual void HandleRequest(int request)
    {
        if (successor != null)
        {
            successor.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("No handler found for the request");
        }
    }
    public IHandler(IHandler? successor = null)
    {
        this.successor = successor;
    }
}

public class Handler : IHandler
{
    public Handler(IHandler? successor = null)
    : base(successor) { }
    public override void HandleRequest(int request)
    {
        Console.WriteLine("The request is handled by the Handler");

        base.HandleRequest(request);
    }
}

public class ConcreteHandler1 : IHandler
{
    public ConcreteHandler1(IHandler? successor = null)
    : base(successor) { }
    public override void HandleRequest(int request)
    {
        if (request <= 10)
        {
            Console.WriteLine($"Request {request} handled by ConcreteHandler1");
        }
        else base.HandleRequest(request);

    }
}

// Another concrete handler
public class ConcreteHandler2 : IHandler
{
    public ConcreteHandler2(IHandler? successor = null)
    : base(successor) { }
    public override void HandleRequest(int request)
    {
        if (request > 10 && request <= 20)
        {
            Console.WriteLine($"Request {request} handled by ConcreteHandler2");
        }
        else base.HandleRequest(request);
    }
}

// Client code
class Program
{
    static void Main()
    {
        // Create handlers
        IHandler handler2 = new ConcreteHandler2();
        IHandler handler1 = new ConcreteHandler1(handler2);
        IHandler handler = new Handler(handler1);

        // Make requests
        handler.HandleRequest(5);
        handler.HandleRequest(15);
        handler.HandleRequest(25);
    }
}
