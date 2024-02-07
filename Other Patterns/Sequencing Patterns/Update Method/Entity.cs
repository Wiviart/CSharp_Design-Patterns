public class Entity
{
    private double x_;
    private double y_;
    static Random random = new Random();
    public Entity()
    {
        x_ = 0;
        y_ = 0;
    }

    public virtual void Update(int i)
    {
        // Update the entity's position.
        x_ += i;
        y_ += i;

        Console.WriteLine($"Entity {i.ToString("00")} position: " + x_ + ", " + y_);
    }

    public double X
    {
        get { return x_; }
        set { x_ = value; }
    }

    public double Y
    {
        get { return y_; }
        set { y_ = value; }
    }
}