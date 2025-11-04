using Latte.Core.Type;


namespace Latte.Cobalt;




public static class CobaltMetrics
{
    public const float BorderSize = 1.5f;

    public const float RectangleRadius = 4f;

    public const float RadialButtonRadius = 10f;
    public const float RadialButtonSelectedIndicatorRadius = RadialButtonRadius - 3f;


    public static readonly Vec2f ButtonSize = new Vec2f(100, 27f);
    public static readonly Vec2f CheckBoxSize = new Vec2f(20, 20);


    public const uint TextSize = 16;
}
