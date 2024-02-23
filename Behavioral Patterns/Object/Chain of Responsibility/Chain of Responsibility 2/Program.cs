public class Program
{
    public static void Main(string[] args)
    {
        IHandler handler1 = new ConcreteHandler1();
        IHandler handler2 = new ConcreteHandler2();
        IHandler handler3 = new ConcreteHandler3();

        handler1.SetNext(handler2).SetNext(handler3);

        var requests = new[]
        {
            new Request { Value = 5 },
            new Request { Value = 15 },
            new Request { Value = 25 }
        };

        foreach (var request in requests)
        {
            handler1.HandleRequest(request);
        }
    }
}

public class Request
{
    public int Value { get; set; }
}

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void HandleRequest(Request request);
}

public class ConcreteHandler1 : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public void HandleRequest(Request request)
    {
        if (request.Value < 10)
        {
            Console.WriteLine($"{GetType().Name} handled request with value {request.Value}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine($"No handler could handle request with value {request.Value}");
        }
    }
}

public class ConcreteHandler2 : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public void HandleRequest(Request request)
    {
        if (request.Value >= 10 && request.Value < 20)
        {
            Console.WriteLine($"{GetType().Name} handled request with value {request.Value}");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine($"No handler could handle request with value {request.Value}");
        }
    }
}

public class ConcreteHandler3 : IHandler
{
    public IHandler SetNext(IHandler handler)
    {
        return this;
    }

    public void HandleRequest(Request request)
    {
        if (request.Value >= 20)
        {
            Console.WriteLine($"{GetType().Name} handled request with value {request.Value}");
        }
        else
        {
            Console.WriteLine($"No handler could handle request with value {request.Value}");
        }
    }
}