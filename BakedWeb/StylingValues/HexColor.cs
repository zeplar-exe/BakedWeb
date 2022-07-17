namespace BakedWeb.StylingValues;

public readonly record struct HexColor(short R, short G, short B)
{
    public override string ToString()
    {
        return $"{R:X}{G:X}{B:X}";
    }
}