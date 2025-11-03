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
        layout.Push(button);
        layout.Push(checkBox);

        AddElements(layout, button, checkBox);
    }
}
