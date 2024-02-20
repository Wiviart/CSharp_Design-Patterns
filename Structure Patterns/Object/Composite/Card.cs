class Card : Equipment
{
    public Card(string name) : base(name)
    {
    }
    public override double NetPrice()
    {
        return 3.0;
    }
}