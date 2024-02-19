class AdditionExpression : Expression
{
    Expression left, right;

    public AdditionExpression(Expression left, Expression right)
    {
        this.left = left;
        this.right = right;
    }

    public override int Evaluate()
    {
        return left.Evaluate() + right.Evaluate();
    }
}