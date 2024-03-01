class ConcreteFlyweight : Flyweight
{
    int intrinsicState;
    public void Operation(int extrinsicstate)
    {
        Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
    }
}