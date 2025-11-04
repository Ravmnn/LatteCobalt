using System.Collections.Generic;

using Latte.Core.Type;
using Latte.UI.Elements;


namespace Latte.Cobalt.Widgets;




public class RadialButtonSelectedIndicatorWidget : CircleElement
{
    public new RadialButtonWidget Parent => (base.Parent as RadialButtonWidget)!;




    public RadialButtonSelectedIndicatorWidget(RadialButtonWidget parent)
        : base(parent, null, 0f)
    {
        Radius = CobaltMetrics.RadialButtonSelectedIndicatorRadius;
        Color = CobaltStyle.RadialButtonSelectedIndicatorColor;
    }


    public override void UnconditionalUpdate()
    {
        Visible = Parent.Selected;

        base.UnconditionalUpdate();
    }
}




public class RadialButtonWidget : RadialButtonElement
{
    public RadialButtonWidget(Element? parent, Vec2f? position, params IEnumerable<RadialButtonElement> chain)
        : base(parent, position, CobaltMetrics.RadialButtonRadius, chain)
    {
        BorderSize = CobaltMetrics.BorderSize;

        this.StylizeActiveNormal(Selected);


        SelectedIndicator = new RadialButtonSelectedIndicatorWidget(this);
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


    protected override void OnSelectedChanged()
    {
        if (MouseState.IsMouseOver)
            this.StylizeActiveHovered(Selected);
        else
            this.StylizeActiveNormal(Selected);

        base.OnSelectedChanged();
    }
}
