namespace BakedWeb;

public record struct Vector2(int X, int Y)
{
    public Vector2 Clamp(Vector2 size)
    {
        return new Vector2(Math.Clamp(Y, Y, size.Y), Math.Clamp(X, X, size.X));
    }
}