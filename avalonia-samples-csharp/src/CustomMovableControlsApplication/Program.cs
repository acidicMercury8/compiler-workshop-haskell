using System;

using Avalonia;
using Avalonia.ReactiveUI;

namespace CustomMovableControlsApplication;

internal class Program {
    // Avalonia configuration, also used by visual designer
    public static AppBuilder BuildAvaloniaApp() =>
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();

    // Initialization code
    [STAThread]
    public static void Main(string[] args) =>
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
}
