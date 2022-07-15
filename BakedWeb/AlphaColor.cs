namespace BakedWeb;

public record struct AlphaColor(byte R, byte G,  byte B, byte A)
{
    public const byte Size = 4;

    public unsafe void Write(byte* ptr)
    {
        *ptr++ = R;
        *ptr++ = G;
        *ptr++ = B;
        *ptr = A;
    }

    public override int GetHashCode()
    {
        return R.GetHashCode() + G.GetHashCode() + B.GetHashCode() + A.GetHashCode();
    }
}