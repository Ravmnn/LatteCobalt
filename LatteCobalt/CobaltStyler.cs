using Latte.UI.Elements;


namespace Latte.Cobalt;




public static class CobaltStyler
{
    public static void StylizeNormal(this ShapeElement element)
    {
        element.Color = CobaltStyle.Color;
        element.BorderColor = CobaltStyle.BorderColor;
    }


    public static void StylizeHovered(this ShapeElement element)
    {
        element.Color = CobaltStyle.HoveredColor;
    }


    public static void StylizePressed(this ShapeElement element)
    {
        element.Color = CobaltStyle.PressedColor;
    }
}
