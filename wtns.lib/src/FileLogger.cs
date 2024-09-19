namespace wtns.lib;

public class FileLogger : ILogger
{

    private readonly string _path;

    public FileLogger(string path = "./logs/")
    {
        _path = path;
        Directory.CreateDirectory(_path);
    }

    /// <inheritdoc/>
    public void LogInfo(string text)
    {
        LogToFile($"[INFO] {text}");
    }

    /// <inheritdoc/>
    public void LogWarning(string text)
    {
        LogToFile($"[WARNING] {text}");
    }

    /// <inheritdoc/>
    public void LogError(string text)
    {
        LogToFile($"[ERROR] {text}");
    }

    /// <summary>
    /// Auxillary method - writes the given text to a log file.
    /// </summary>
    /// <param name="text">The text to write to the log file.</param>
    private void LogToFile(string text)
    {
        var fileName = $"{_path}{DateTime.Now:yyyy-MM-dd}.log";
        File.AppendAllText(fileName, text);
    }
}