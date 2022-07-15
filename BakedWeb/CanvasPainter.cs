namespace BakedWeb;

public class CanvasPainter
{
    public unsafe void Draw(ref byte[] target)
    {
        fixed (byte* b = target)
        {
            var colorCount = target.Length / AlphaColor.Size;
            var redColor = new AlphaColor(255, 0, 0, 255);

            for (var i = 0; i < colorCount; i++)
            {
                redColor.Write(b);

                *b += AlphaColor.Size;
            }
        }
    }
}