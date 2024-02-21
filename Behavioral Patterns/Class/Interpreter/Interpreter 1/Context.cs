public class Context
{
    private Dictionary<string, Expression> _variables = new Dictionary<string, Expression>();

    public void SetVariable(string variableName, Expression expression)
    {
        _variables[variableName] = expression;
    }

    public Expression GetVariable(string variableName)
    {
        if (_variables.ContainsKey(variableName))
        {
            return _variables[variableName];
        }
        else
        {
            throw new ArgumentException($"Variable {variableName} not found");
        }
    }
}