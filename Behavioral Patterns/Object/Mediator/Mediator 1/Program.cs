// Mediator interface
public interface IMediator
{
    void SendMessage(string message, Colleague colleague);
}

// Colleague interface
public abstract class Colleague
{
    protected IMediator mediator;

    public Colleague(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}

// Concrete Mediator
public class ConcreteMediator : IMediator
{
    private List<Colleague> colleagues = new List<Colleague>();

    public void AddColleague(Colleague colleague)
    {
        colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague sender)
    {
        foreach (var colleague in colleagues)
        {
            // Exclude the sender from receiving the message
            if (colleague != sender)
            {
                colleague.Receive(message);
            }
        }
    }
}

// Concrete Colleague
public class ConcreteColleague : Colleague
{
    string name;
    public ConcreteColleague(IMediator mediator, string name) : base(mediator)
    {
        this.name = name;
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{name} sending message: {message}");
        mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{name} receiving message: {message}");
    }
}

// Client
class Program
{
    static void Main()
    {
        // Create mediator
        ConcreteMediator mediator = new ConcreteMediator();

        // Create colleagues
        ConcreteColleague colleague1 = new ConcreteColleague(mediator, "Colleague1");
        ConcreteColleague colleague2 = new ConcreteColleague(mediator, "Colleague2");

        // Add colleagues to the mediator
        mediator.AddColleague(colleague1);
        mediator.AddColleague(colleague2);

        // Send messages through the mediator
        colleague1.Send("Hello from colleague1!");
        colleague2.Send("Hi from colleague2!");
    }
}
