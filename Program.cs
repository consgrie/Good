using System;

enum LogLevel { Info, Warning, Error }

sealed class Logger
{
    private static readonly Logger instance = new Logger();
    public static Logger Instance => instance;
    private Logger() { }
    public void Log(LogLevel level, string message) => Console.WriteLine($"[{level}] {message}");
}

class Program
{
    static void Main()
    {
        Logger.Instance.Log(LogLevel.Info, "Запуск");
        Logger.Instance.Log(LogLevel.Warning, "Предупреждение");
        Logger.Instance.Log(LogLevel.Error, "Ошибка");
    }
}
