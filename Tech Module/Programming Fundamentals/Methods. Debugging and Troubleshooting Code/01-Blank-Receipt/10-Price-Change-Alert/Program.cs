using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double limit = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double diff = GetDiffernce(last, price);
            bool isSignificantDifference = IsThereDifference(diff, limit);
            string message = Get(price, last, diff, isSignificantDifference);
            Console.WriteLine(message);
            last = price;
        }
    }

    static string Get(double price, double last, double difference, bool etherTrueOrFalse)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!etherTrueOrFalse)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, difference);
        return message;
    }

    private static bool IsThereDifference(double diff, double limit)
    {
        if (Math.Abs(diff) >= limit)
        {
            return true;
        }
        return false;
    }

    private static double GetDiffernce(double last, double price)
    {
        double difference = (price - last) / last;
        return difference;
    }
}

