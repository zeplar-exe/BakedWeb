using BakedWeb.Javascript;

namespace BakedWeb.Widgets;

public abstract class Widget
{
    public Vector2 DesiredSize { get; set; }

    public virtual Vector2 Measure(Vector2 available)
    {
        return DesiredSize.Clamp(available);
    }
    
    public abstract void Build(Rect constraint, CanvasFunctionBuilder builder);
}