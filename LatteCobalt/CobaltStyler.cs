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


    public static void StylizeActive(this ShapeElement element)
    {
        element.Color = CobaltStyle.ActiveColor;
    }




    public static void StylizeActiveNormal(this ShapeElement element, bool active)
    {
        if (active)
            element.Color = CobaltStyle.ActiveColor;
        else
            element.StylizeNormal();
    }


    public static void StylizeActiveHovered(this ShapeElement element, bool active)
    {
        if (active)
            element.Color = CobaltStyle.ActiveHoveredColor;
        else
            element.StylizeHovered();
    }


    public static void StylizeActivePressed(this ShapeElement element, bool active)
    {
        if (active)
            element.Color = CobaltStyle.ActivePressedColor;
        else
            element.StylizePressed();
    }
}
