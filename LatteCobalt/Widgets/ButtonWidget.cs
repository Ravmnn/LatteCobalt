using Latte.Core.Type;
using Latte.UI.Elements;


namespace Latte.Cobalt.Widgets;




public class ButtonWidget : ButtonElement
{
    public ButtonWidget(Element? parent, Vec2f? position, string? text)
        : base(parent, position, CobaltMetrics.ButtonSize, null)
    {
        Radius = CobaltMetrics.RectangleRadius;
        BorderSize = CobaltMetrics.BorderSize;

        this.StylizeNormal();


        if (text is not null)
            Text = new TextWidget(this, null, text) { IgnoreMouseInput = true };
    }




    public override void OnMouseEnter()
    {
        this.StylizeHovered();

        base.OnMouseEnter();
    }


    public override void OnMouseLeave()
    {
        this.StylizeNormal();

        base.OnMouseLeave();
    }


    public override void OnMouseDown()
    {
        this.StylizePressed();

        base.OnMouseDown();
    }


    public override void OnMouseUp()
    {
        if (MouseState.IsMouseOver)
            this.StylizeHovered();
        else
            this.StylizeNormal();

        base.OnMouseUp();
    }
}
