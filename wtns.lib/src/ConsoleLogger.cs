namespace wtns.lib;

/// <summary>
/// A logger implementation that writes to the console.
/// </summary>
public class ConsoleLogger : ILogger
{
    /// <inheritdoc/>
    public void LogInfo(string text)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"[INFO] {text}");
        Console.ResetColor();
    }

    /// <inheritdoc/>
    public void LogWarning(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[WARNING] {text}");
        Console.ResetColor();
    }

    /// <inheritdoc/>
    public void LogError(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR] {text}");
        Console.ResetColor();
    }
}