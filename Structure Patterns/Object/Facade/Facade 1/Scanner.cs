public class Scanner
{
    private readonly string _sourceCode;
    private int _currentIndex;

    public Scanner(string sourceCode)
    {
        _sourceCode = sourceCode;
        _currentIndex = 0;
    }

    public char GetNextToken()
    {
        if (_currentIndex < _sourceCode.Length)
        {
            char token = _sourceCode[_currentIndex];
            _currentIndex++;
            return token;
        }

        return '\0';
    }
}