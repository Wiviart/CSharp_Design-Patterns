// Abstract Expression
public abstract class FullNameExpression
{
    public abstract string Interpret(Dictionary<string, string> context);
}

// Concrete Expressions
public class EnglishFullNameExpression : FullNameExpression
{
    public override string Interpret(Dictionary<string, string> context)
    {
        string firstName = context["firstName"];
        string lastName = context["lastName"];
        return $"Full Name: {firstName} {lastName}";
    }
}

public class VietnameseFullNameExpression : FullNameExpression
{
    public override string Interpret(Dictionary<string, string> context)
    {
        string firstName = context["firstName"];
        string lastName = context["lastName"];
        return $"Họ và Tên: {lastName} {firstName}";
    }
}

// Context
public class FullNameContext
{
    private FullNameExpression _expression;

    public FullNameContext(FullNameExpression expression)
    {
        _expression = expression;
    }

    public void SetExpression(FullNameExpression expression)
    {
        _expression = expression;
    }

    public string Interpret(Dictionary<string, string> context)
    {
        return _expression.Interpret(context);
    }
}

// Client Code
class Program
{
    static void Main()
    {
        // Set up context with initial English full name
        FullNameExpression englishExpression = new EnglishFullNameExpression();
        FullNameContext context = new FullNameContext(englishExpression);

        // Provide context values (first name and last name)
        Dictionary<string, string> values = new Dictionary<string, string>
        {
            { "firstName", "John" },
            { "lastName", "Doe" }
        };

        // Interpret and print full name in English
        Console.WriteLine("In English: " + context.Interpret(values));

        // Switch to Vietnamese full name
        context.SetExpression(new VietnameseFullNameExpression());

        // Interpret and print full name in Vietnamese
        Console.WriteLine("In Vietnamese: " + context.Interpret(values));
    }
}
