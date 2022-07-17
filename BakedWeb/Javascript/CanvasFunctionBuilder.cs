using System.Text;

namespace BakedWeb.Javascript;

public class CanvasFunctionBuilder
{
    public const string ContextParameter = "context";
    
    private StringBuilder Builder { get; }

    public CanvasFunctionBuilder()
    {
        Builder = new StringBuilder();
    }

    public CanvasFunctionBuilder AppendConst(string name, object value)
    {
        return AppendStatement($"const {name} = {value}");
    }
    
    public CanvasFunctionBuilder AppendVariable(string name, object value)
    {
        return AppendStatement($"let {name} = {value}");
    }

    public CanvasFunctionBuilder AppendMethodCall(string name, params object[] parameters)
    {
        return AppendStatement($"{ContextParameter}.{name}({string.Join(',', parameters)})");
    }

    private CanvasFunctionBuilder AppendStatement(string statement)
    {
        Builder.AppendLine(statement);

        return this;
    }

    public string Complete(string name)
    {
        return new StringBuilder()
            .AppendLine($"function {name}({ContextParameter}) {{")
            .Append(Builder)
            .Append('}')
            .ToString();
    }

    public override string ToString()
    {
        return Builder.ToString();
    }
}