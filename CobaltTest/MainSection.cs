using Latte.UI.Elements;
using Latte.Application;

using Latte.Cobalt.Widgets;


namespace Latte.Cobalt.Test;




public sealed class MainSection : Section
{
    public MainSection()
    {
        var layout = new HorizontalLayoutElement(null, null)
        {
            Margin = 5f
        };

        var button = new ButtonWidget(null, null, "button");
        var checkBox = new CheckBoxWidget(null, null);
        var radialButton1 = new RadialButtonWidget(null, null);
        var radialButton2 = new RadialButtonWidget(null, null);

        radialButton1.Chain = [radialButton1, radialButton2];
        radialButton2.Chain = [radialButton1, radialButton2];

        layout.Push(button);
        layout.Push(checkBox);
        layout.Push(radialButton1);
        layout.Push(radialButton2);

        AddElements(layout, button, checkBox, radialButton1, radialButton2);
    }
}
