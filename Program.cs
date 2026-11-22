using System;

sealed class Logger
{
    private static readonly Logger instance = new Logger();
    public static Logger Instance => instance;
    private Logger() { }
    public void Log(string message) => Console.WriteLine(message);
}

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Программа запущена");
        Logger.Instance.Log("Singleton работает: " + ReferenceEquals(Logger.Instance, Logger.Instance));
    }
}
