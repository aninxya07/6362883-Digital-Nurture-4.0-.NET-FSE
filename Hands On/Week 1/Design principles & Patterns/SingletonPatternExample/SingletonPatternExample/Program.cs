using System;

class Program
{
    static void Main(string[] args)
    {
        var logger1 = Logger.GetInstance();
        logger1.Log("First log message");

        var logger2 = Logger.GetInstance();
        logger2.Log("Second log message");

        if (object.ReferenceEquals(logger1, logger2))
        {
            Console.WriteLine("Singleton confirmed: Both loggers are the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed: Different instances detected.");
        }
    }
}