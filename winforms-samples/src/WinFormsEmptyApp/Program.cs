using System;

namespace WinFormsApp1;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
#if NET6_0_OR_GREATER
        ApplicationConfiguration.Initialize();
#endif

#if NET5_0 || NETCOREAPP3_1
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
#endif

        Application.Run(new MainForm());
    }
}
