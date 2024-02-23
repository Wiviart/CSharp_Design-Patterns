using System;
using System.Collections.Generic;

// Element interface
interface IElement
{
    void Accept(IVisitor visitor);
}

// Concrete element
class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }

    public void OperationA()
    {
        Console.WriteLine("Operation A of ConcreteElementA");
    }
}

// Concrete element
class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }

    public void OperationB()
    {
        Console.WriteLine("Operation B of ConcreteElementB");
    }
}

// Visitor interface
interface IVisitor
{
    void VisitConcreteElementA(ConcreteElementA elementA);
    void VisitConcreteElementB(ConcreteElementB elementB);
}

// Concrete visitor
class ConcreteVisitor : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA elementA)
    {
        Console.WriteLine("Visitor is processing ConcreteElementA");
        elementA.OperationA();
    }

    public void VisitConcreteElementB(ConcreteElementB elementB)
    {
        Console.WriteLine("Visitor is processing ConcreteElementB");
        elementB.OperationB();
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
