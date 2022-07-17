using System.Text;

namespace BakedWeb;

public class JavascriptFunctionBuilder
{
    private string Name { get; }
    private JavascriptBuilder JavascriptBuilder { get; }
    
    private StringBuilder StringBuilder { get; }

    internal JavascriptFunctionBuilder(string name, JavascriptBuilder builder)
    {
        Name = name;
        JavascriptBuilder = builder;
        StringBuilder = new StringBuilder();
    }

    public JavascriptFunctionBuilder WithVariable(string name, string value)
    {
        StringBuilder.AppendLine($"let {name} = {value}");

        return this;
    }
    
    public JavascriptFunctionBuilder WithConst(string name, string value)
    {
        StringBuilder.AppendLine($"const {{name}} = {value}");

        return this;
    }
    
    public JavascriptFunctionBuilder WithStatement(string statement)
    {
        StringBuilder.AppendLine(statement);

        return this;
    }

    public JavascriptBuilder Complete()
    {
        JavascriptBuilder.StringBuilder.Append(StringBuilder).AppendLine();

        return JavascriptBuilder;
    }
}