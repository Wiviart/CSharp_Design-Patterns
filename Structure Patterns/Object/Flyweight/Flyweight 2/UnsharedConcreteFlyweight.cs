class UnsharedConcreteFlyweight : Flyweight
{
     private int intrinsicstate;

    public UnsharedConcreteFlyweight(int intrinsicstate)
    {
        this.intrinsicstate = intrinsicstate;
    }

    public void Operation(int extrinsicstate)
    {
        Console.WriteLine("Unshared Flyweight: " + intrinsicstate + ", " + extrinsicstate);
    }
}