using Latte.Core.Type;
using Latte.UI;
using Latte.UI.Elements;


namespace Latte.Cobalt.Widgets;




public class CheckBoxIndicatorWidget : SpriteElement
{
    public new CheckBoxWidget Parent => (base.Parent as CheckBoxWidget)!;




    public CheckBoxIndicatorWidget(CheckBoxElement parent)
        : base(parent, CobaltEmbeddedResources.CheckBoxMark(), null, new Vec2f())
    {
        SizePolicy = SizePolicy.FitParent;
        SizePolicyMargin = new Vec2f(0.4f, 0.4f);
    }


    public override void UnconditionalUpdate()
    {
        Visible = Parent.Selected;

        base.UnconditionalUpdate();
    }
}




public class CheckBoxWidget : CheckBoxElement
{
    public CheckBoxWidget(Element? parent, Vec2f? position, bool selected = false)
        : base(parent, position, selected)
    {
        Radius = CobaltMetrics.RectangleRadius;
        BorderSize = CobaltMetrics.RectangleBorderSize;
        Size = CobaltMetrics.CheckBoxSize;

        this.StylizeActiveNormal(Selected);


        SelectedIndicator = new CheckBoxIndicatorWidget(this);
    }




    public override void OnMouseEnter()
    {
        this.StylizeActiveHovered(Selected);

        base.OnMouseEnter();
    }


    public override void OnMouseLeave()
    {
        this.StylizeActiveNormal(Selected);

        base.OnMouseLeave();
    }


    public override void OnMouseDown()
    {
        this.StylizeActivePressed(Selected);

        base.OnMouseDown();
    }


    public override void OnMouseUp()
    {
        if (MouseState.IsMouseOver)
            // use "!Selected" because OnMouseUp is called before OnMouseClick, which
            // is the original logic that inverts the "Selected" property. That prevents
            // a color change bug.
            this.StylizeActiveHovered(!Selected);
        else
            this.StylizeActiveNormal(Selected);

        base.OnMouseUp();
    }
}
