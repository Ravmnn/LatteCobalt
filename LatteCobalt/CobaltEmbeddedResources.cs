using System.Reflection;

using SFML.Graphics;

using Latte.Core;


namespace Latte.Cobalt;




public static class CobaltEmbeddedResources
{
    public static Assembly CobaltAssembly => typeof(CobaltEmbeddedResources).Assembly;
    public static string ResourcePath => "Latte.Cobalt.Resources";


    public static string CheckBoxMarkPath => $"{ResourcePath}.Icons.CheckBoxMark.png";




    public static Texture CheckBoxMark()
        => EmbeddedResourceLoader.LoadTexture(CheckBoxMarkPath, CobaltAssembly);
}
