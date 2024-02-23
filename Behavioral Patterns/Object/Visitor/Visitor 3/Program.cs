// Element interface
abstract class IElement
{
    public virtual void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElement(this);
    }
    public virtual void Operation()
    {
        Console.WriteLine($"Operation of {this.GetType().Name}");
    }
}

// Concrete element
class ConcreteElementA : IElement { }
class ConcreteElementB : IElement { }

// Visitor interface
interface IVisitor
{
    void VisitConcreteElement(IElement element);
}

// Concrete visitor
class ConcreteVisitor : IVisitor
{
    public void VisitConcreteElement(IElement element)
    {
        Console.WriteLine($"Visitor is processing {element.GetType().Name}");
        element.Operation();
    }
}

// Object structure
class ObjectStructure
{
    private List<IElement> elements = new List<IElement>();

    public void Attach(IElement element)
    {
        elements.Add(element);
    }

    public void Detach(IElement element)
    {
        elements.Remove(element);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}

class Program
{
    static void Main()
    {
        ObjectStructure objectStructure = new ObjectStructure();
        objectStructure.Attach(new ConcreteElementA());
        objectStructure.Attach(new ConcreteElementB());

        IVisitor concreteVisitor = new ConcreteVisitor();
        objectStructure.Accept(concreteVisitor);
    }
}
