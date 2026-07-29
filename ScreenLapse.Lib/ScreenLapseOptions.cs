namespace ScreenLapse.Lib;

public class ScreenLapseOptions
{
    public const string AppName = "ScreenLapse";

    public string CapturePath { get; set; } = ".\\captures";
    public string OutputPath { get; set; } = ".\\output";
}
