namespace BakedWeb;

public record struct Rect(Vector2 Position, Vector2 Size)
{
    public int X => Position.X;
    public int Y => Position.Y;
    public int Width => Size.X;
    public int Height => Size.Y;

    public Rect(int x, int y, int width, int height) : this(new Vector2(x, y), new Vector2(width, height))
    {
        
    }
}