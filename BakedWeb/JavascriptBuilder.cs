using System.Text;

namespace BakedWeb;

public class JavascriptBuilder
{
    internal StringBuilder StringBuilder { get; }

    public JavascriptBuilder()
    {
        StringBuilder = new StringBuilder();
    }
    
    public JavascriptBuilder WithVariable(string name, string value)
    {
        StringBuilder.AppendLine($"let {name} = {value}");

        return this;
    }
    
    public JavascriptBuilder WithConst(string name, string value)
    {
        StringBuilder.AppendLine($"const {{name}} = {value}");

        return this;
    }
    
    public JavascriptFunctionBuilder NewFunction()
    {
        return new JavascriptFunctionBuilder(GenerateName(), this);
    }

    private string GenerateName()
    {
        return Guid.NewGuid().ToString("N");
    }
    
    public string Build()
    {
        return StringBuilder.ToString();
    }
}