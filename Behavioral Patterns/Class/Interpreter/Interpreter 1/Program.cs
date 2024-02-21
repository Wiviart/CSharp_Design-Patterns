class NumberExpression : TerminalExpression
{
    public NumberExpression(int value) : base(value) { }
}

class AddExpression : NonTerminalExpression
{
    public AddExpression(Expression left, Expression right) : base(left, right) { }
}

class Program
{
    static void Main()
    {
        // Create a context
        Context context = new Context();

        // Set variables with values
        context.SetVariable("a", new NumberExpression(5));
        context.SetVariable("b", new NumberExpression(10));

        // Create expressions
        Expression expression = new AddExpression(new NumberExpression(20), new NumberExpression(30));
        Expression variableExpression = context.GetVariable("a");
        Expression combinedExpression = new AddExpression(variableExpression, new NumberExpression(15));

        // Interpret expressions
        Console.WriteLine($"Result of constant expression: {expression.Interpret()}");
        Console.WriteLine($"Result of variable expression: {variableExpression.Interpret()}");
        Console.WriteLine($"Result of combined expression: {combinedExpression.Interpret()}");
    }
}