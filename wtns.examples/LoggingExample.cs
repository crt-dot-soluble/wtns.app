using wtns.lib;

// Creating a console logger
var consoleLogger = new ConsoleLogger();
consoleLogger.LogInfo("Console info");
consoleLogger.LogWarning("Console warning");
consoleLogger.LogError("Console error");

// Creating a file logger
var fileLogger = new FileLogger();
fileLogger.LogInfo("File info");
fileLogger.LogWarning("File warning");
fileLogger.LogError("File error");

// Creating a composite logger
var compositeLogger = new CompositeLogger(consoleLogger, fileLogger);
compositeLogger.LogInfo("Logging to multiple outputs");