class NumberExpression : Expression
{
    private int value;

    public NumberExpression(int value)
    {
        this.value = value;
    }

    public override int Evaluate()
    {
        return value;
    }
}