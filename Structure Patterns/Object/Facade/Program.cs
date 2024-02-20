class Program
{
    static void Main(string[] args)
    {
        Compiler compilerFacade = new Compiler();
        string sourceCode = "Hello, World!";

        compilerFacade.CompileCode(sourceCode);
    }
}