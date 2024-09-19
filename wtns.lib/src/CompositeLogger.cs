namespace wtns.lib;

/// <summary>
/// A logger implementation which allows for logging to multiple sources. (i.e. Console and File)
/// </summary>
public class CompositeLogger : ILogger
{
    private readonly ILogger[] _loggers;

    /// <summary>
    /// Initializes a logger implementation which allows for logging to multiple sources. (i.e. Console and File)
    /// </summary>
    /// <param name="loggers">The <see cref="ILogger"/> implementations to write to.</param>
    public CompositeLogger(params ILogger[] loggers)
    {
        _loggers = loggers;
    }

    /// <inheritdoc/>
    public void LogInfo(string text)
    {
        foreach (ILogger logger in _loggers)
        {
            logger.LogInfo(text);
        }
    }

    /// <inheritdoc/>
    public void LogWarning(string text)
    {
        foreach (ILogger logger in _loggers)
        {
            logger.LogWarning(text);
        }
    }

    /// <inheritdoc/>
    public void LogError(string text)
    {
        foreach (ILogger logger in _loggers)
        {
            logger.LogError(text);
        }
    }
}