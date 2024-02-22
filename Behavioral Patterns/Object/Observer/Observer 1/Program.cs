using System.Threading;
class Observer
{
    protected string name;

    protected Observer(string name)
    {
        this.name = name;
    }

    public virtual void Update(Subject subject) { }
    public virtual string GetName() => name;
}

class ConcreteObserver : Observer
{
    Observer observerState = null;
    public ConcreteObserver(string name) : base(name)
    {
        Console.WriteLine($"Concrete Observer {name}");
    }
    public override void Update(Subject subject)
    {
        observerState = subject.GetState();
        Console.WriteLine($"Concrete Observer {name} Update");
    }
}


class Subject
{
    protected List<Observer> observers = new List<Observer>();

    public virtual void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public virtual void Detach(Observer observer)
    {
        observers.Remove(observer);
    }

    public virtual void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }

    public virtual Observer GetState() { return null; }
    public virtual void SetState(Observer state) { }
}

class ConcreteSubject : Subject
{
    private Observer subjectState = null;

    public override Observer GetState()
    {
        return subjectState;
    }

    public override void SetState(Observer state)
    {
        subjectState = state;
        Console.WriteLine($"Concrete Subject Set State {state.GetName()}");
    }
}


class Program
{
    static void Main()
    {
        Subject s = new ConcreteSubject();
        Observer o1 = new ConcreteObserver("Observer 1");
        Observer o2 = new ConcreteObserver("Observer 2");
        s.Attach(o1);
        s.Attach(o2);
        s.SetState(o2);

        while (true)
        {
            Console.WriteLine("Subject State: " + s.GetState().GetName());
            s.Notify();
            Thread.Sleep(1000);
        }
    }
}