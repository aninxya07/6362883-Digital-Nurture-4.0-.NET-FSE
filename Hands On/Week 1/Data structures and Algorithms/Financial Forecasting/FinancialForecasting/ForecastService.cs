public static class ForecastService
{
    public static double ForecastRecursive(double amount, double rate, int years)
    {
        if (years == 0)
            return amount;

        return ForecastRecursive(amount, rate, years - 1) * (1 + rate);
    }

    public static double ForecastMemo(double amount, double rate, int years, double[] memo)
    {
        if (years == 0)
            return amount;

        if (memo[years] != 0)
            return memo[years];

        memo[years] = ForecastMemo(amount, rate, years - 1, memo) * (1 + rate);
        return memo[years];
    }
}