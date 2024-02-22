class Caretaker
{
    private Memento _memento;

    public void SaveMemento(Memento memento)
    {
        _memento = memento;
        Console.WriteLine($"Saved memento with state {_memento.GetState()}");
    }

    public Memento RetrieveMemento()
    {
        Console.WriteLine($"Retrieved memento with state {_memento.GetState()}");
        return _memento;
    }
}

class Originator
{
    private string _state;

    public void SetState(string state)
    {
        Console.WriteLine($"Set state to {state}");
        _state = state;
    }

    public Memento CreateMemento()
    {
        Console.WriteLine($"Created memento with state {_state}");
        return new Memento(_state);
    }

    public void SetMemento(Memento memento)
    {
        _state = memento.GetState();
        Console.WriteLine($"Restored state to {_state}");
    }
}

class Memento
{
    private readonly string _state;

    public Memento(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}

class Program
{
    static void Main()
    {
        var originator = new Originator();
        var caretaker = new Caretaker();

        originator.SetState("State1");
        originator.SetState("State2");
        caretaker.SaveMemento(originator.CreateMemento());
        originator.SetState("State3");
        originator.SetState("State4");
        originator.SetMemento(caretaker.RetrieveMemento());
        originator.SetState("State5");
        caretaker.SaveMemento(originator.CreateMemento());
        originator.SetState("State6");
        originator.SetMemento(caretaker.RetrieveMemento());
    }
}

