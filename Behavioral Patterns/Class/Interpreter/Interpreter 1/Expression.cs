// Abstract Expression
public abstract class Expression
{
    public abstract int Interpret();
}

// Terminal Expression (has no sub-expressions)
public class TerminalExpression : Expression
{
    private int _number;

    public TerminalExpression(int number)
    {
        _number = number;
    }

    public override int Interpret()
    {
        return _number;
    }
}

// Non-terminal Expression has two terminal expressions
public class NonTerminalExpression : Expression
{
    private Expression _left;
    private Expression _right;

    public NonTerminalExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret()
    {
        return _left.Interpret() + _right.Interpret();
    }
}