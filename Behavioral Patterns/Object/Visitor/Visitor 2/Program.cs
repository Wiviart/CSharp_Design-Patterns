using System;
using System.Collections.Generic;

// Element interface
interface IEquipment
{
    string Name { get; }
    double Power();
    decimal NetPrice();
    decimal DiscountPrice();
    void Accept(IEquipmentVisitor visitor);
}

// Concrete element
class FloppyDisk : IEquipment
{
    public string Name => "Floppy Disk";

    public double Power() => 5.0;

    public decimal NetPrice() => 10.0m;

    public decimal DiscountPrice() => 8.0m;

    public void Accept(IEquipmentVisitor visitor)
    {
        visitor.VisitFloppyDisk(this);
    }
}

// Concrete element
class Chassis : IEquipment
{
    private List<IEquipment> _parts = new List<IEquipment>();

    public string Name => "Chassis";

    public double Power() => _parts.Sum(part => part.Power());

    public decimal NetPrice() => _parts.Sum(part => part.NetPrice());

    public decimal DiscountPrice() => _parts.Sum(part => part.DiscountPrice()) * 0.9m;

    public void AddPart(IEquipment part)
    {
        _parts.Add(part);
    }

    public void Accept(IEquipmentVisitor visitor)
    {
        foreach (var part in _parts)
        {
            part.Accept(visitor);
        }
        visitor.VisitChassis(this);
    }
}

// Visitor interface
interface IEquipmentVisitor
{
    void VisitFloppyDisk(FloppyDisk floppyDisk);
    void VisitChassis(Chassis chassis);
}

// Concrete visitor
class PricingVisitor : IEquipmentVisitor
{
    private decimal _total = 0.0m;

    public decimal GetTotalPrice() => _total;

    public void VisitFloppyDisk(FloppyDisk floppyDisk)
    {
        _total += floppyDisk.NetPrice();
    }

    public void VisitChassis(Chassis chassis)
    {
        _total += chassis.DiscountPrice();
    }
}

class Program
{
    static void Main()
    {
        Chassis computer = new Chassis();
        computer.AddPart(new FloppyDisk());
        computer.AddPart(new FloppyDisk());
        computer.AddPart(new FloppyDisk());

        PricingVisitor pricingVisitor = new PricingVisitor();
        computer.Accept(pricingVisitor);

        Console.WriteLine($"Total Price: {pricingVisitor.GetTotalPrice()}");
    }
}
