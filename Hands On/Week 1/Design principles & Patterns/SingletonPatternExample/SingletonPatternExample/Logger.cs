using System;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private Logger()
    {
        Console.WriteLine("Logger instance created");
    }

    // Public method to get the singleton instance
    public static Logger GetInstance()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
        }
        return _instance;
    }

    // Example log method
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}