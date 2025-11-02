using Latte.Application;
using Latte.Cobalt.Widgets;


namespace Latte.Cobalt.Test;




public sealed class MainSection : Section
{
    public MainSection()
    {
        AddElement(new ButtonWidget(null, null, "button"));
    }
}
