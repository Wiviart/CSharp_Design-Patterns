class CompositeEquipment : Equipment
{
    private List<Equipment> _equipment;

    public CompositeEquipment(string name) : base(name)
    {
        _equipment = new List<Equipment>();
    }

    public override double NetPrice()
    {
        double total = 0;
        foreach (var e in _equipment)
        {
            total += e.NetPrice();
        }
        return total;
    }

    public override void Add(Equipment equipment)
    {
        _equipment.Add(equipment);
    }

    public override void Remove(Equipment equipment)
    {
        _equipment.Remove(equipment);
    }
}