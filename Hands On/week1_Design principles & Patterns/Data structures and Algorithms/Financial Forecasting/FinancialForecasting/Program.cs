using System;

class Program
{
    static void Main(string[] args)
    {
        double initialAmount = 1000;
        double annualRate = 0.05;
        int years = 5;

        double result = ForecastService.ForecastRecursive(initialAmount, annualRate, years);
        Console.WriteLine("Future Value using Recursion: " + result.ToString("F2"));

        double[] memo = new double[years + 1];
        double optimized = ForecastService.ForecastMemo(initialAmount, annualRate, years, memo);
        Console.WriteLine("Future Value using Memoization: " + optimized.ToString("F2"));
    }
}