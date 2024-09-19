namespace wtns.lib;

public interface ILogger
{
    // public void LogDebug(string text);

    /// <summary>
    /// Logs standard information.
    /// </summary>
    /// <param name="text">The text to log.</param>
    public void LogInfo(string text);

    /// <summary>
    /// Logs warning information.
    /// </summary>
    /// <param name="text">The text to log.</param>
    public void LogWarning(string text);

    /// <summary>
    /// Logs error information.
    /// </summary>
    /// <param name="text">The text to log.</param>
    public void LogError(string text);
}