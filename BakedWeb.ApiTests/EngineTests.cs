namespace BakedWeb.ApiTests;

[TestFixture]
public class EngineTests
{
    [Test]
    public void TestEngine()
    {
        var result = Parse("function ABC() { return 1 }").CallMethod("ABC");
        
        Assert.That(result, Is.EqualTo(1));
    }

    private ParsedScript Parse(string script)
    {
        using var engine = new ScriptEngine("jscript");

        return engine.Parse(script);
    } 
}