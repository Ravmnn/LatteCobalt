using Latte.Core.Type;
using Latte.UI.Elements;


namespace Latte.Cobalt.Widgets;




public class TextWidget : TextElement
{
    public TextWidget(Element? parent, Vec2f? position, string text)
        : base(parent, position, CobaltMetrics.TextSize, text)
    {
        Color = CobaltStyle.TextColor;
    }
}
