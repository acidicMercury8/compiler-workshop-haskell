using System;

using Avalonia;
using Avalonia.ReactiveUI;

namespace MultiTargetSampleApp.Windows;

internal class Program {
     /// <summary>
    /// Avalonia configuration, also used by visual designer
    /// </summary>
    /// <returns></returns>
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI()
            .UseWin32();

    /// <summary>
    /// Initialization code
    /// </summary>
    /// <param name="args"></param>
    [STAThread]
    public static void Main(string[] args) =>
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
}
