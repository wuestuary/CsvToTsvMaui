using Microsoft.Maui.Controls;

namespace CsvToTsvMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
