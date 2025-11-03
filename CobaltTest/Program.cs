using SFML.Window;

using Latte.Application;


namespace Latte.Cobalt.Test;




class Program
{
    static void Main(string[] args)
    {
        var settings = AppInitializationSettings.Default with
        {
            ContextSettings = AppInitializationSettings.DefaultContextSettings with
            {
                AntialiasingLevel = 4
            }
        };

        App.Init(VideoMode.DesktopMode, "Cobalt Test", settings);
        App.Debugger!.EnableKeyShortcuts = true;


        App.Section = new MainSection();


        while (!App.ShouldQuit)
        {
            App.Update();
            App.Draw();
        }


        App.Deinit();
    }
}
