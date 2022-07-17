using BakedWeb.Javascript;

namespace BakedWeb.Widgets.Primitive;

public class RectangleWidget : Widget
{
    public override void Build(Rect constraint, CanvasFunctionBuilder builder)
    {
        builder.AppendMethodCall("fillRect", 
            constraint.X, constraint.Y, constraint.Width, constraint.Height);
    }
}