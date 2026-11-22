using System;
using System.IO;

sealed class Logger
{
    private static readonly Logger instance = new Logger();
    public static Logger Instance => instance;
    private Logger() { }
    public void Log(string message)
    {
        Console.WriteLine(message);
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Программа запущена");
        Logger.Instance.Log("Сообщение записано в log.txt");
    }
}
