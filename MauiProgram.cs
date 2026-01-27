using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace CsvToTsvMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()          // ← 必须在这里
            .UseMauiCommunityToolkit(); // ← 紧跟在后面

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
