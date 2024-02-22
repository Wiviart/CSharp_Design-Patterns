public class Compiler
{
    public void CompileCode(string sourceCode)
    {
        CodeGenerator codeGenerator = new CodeGenerator();
        Scanner scanner = new Scanner(sourceCode);
        Parser parser = new Parser();

        ProgramNode parseTree = parser.Parse(scanner);
        codeGenerator.GenerateCode(parseTree);
    }
}