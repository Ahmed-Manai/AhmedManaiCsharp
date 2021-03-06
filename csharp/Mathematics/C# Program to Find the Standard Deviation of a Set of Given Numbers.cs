/*
 * C# Program to Find the Standard Deviation of a Set of Given Numbers
 */
using System;
using System.Collections.Generic;
namespace SampleApp
{
internal class Program
{
    private static void Main()
    {
        List<double> number = new List<double> { 1, 2, 3, 4, 5, 6 };
        double mean = number.Mean();
        double variance = number.Variance();
        double sd = number.StandardDeviation();
        Console.WriteLine("Mean: {0}  , Variance: {1}  , SD: {2}  ", mean, variance, sd);
        Console.ReadKey();
    }
}
public static class list
{
    public static double Mean(this List<double> values)
    {
        return values.Count == 0 ? 0 : values.Mean(0, values.Count);
    }

    public static double Mean(this List<double> values, int start, int end)
    {
        double s = 0;
        for (int i = start; i < end; i++)
            {
                s += values[i];
            }
        return s / (end - start);
    }

    public static double Variance(this List<double> values)
    {
        return values.Variance(values.Mean(), 0, values.Count);
    }

    public static double Variance(this List<double> values, double mean)
    {
        return values.Variance(mean, 0, values.Count);
    }

    public static double Variance(this List<double> values, double mean, int start, int end)
    {
        double variance = 0;
        for (int i = start; i < end; i++)
            {
                variance += Math.Pow((values[i] - mean), 2);
            }
        int n = end - start;
        if (start > 0) n -= 1;
        return variance / (n);
    }
    public static double StandardDeviation(this List<double> values)
    {
        return values.Count == 0 ? 0 : values.StandardDeviation(0, values.Count);
    }
    public static double StandardDeviation(this List<double> values, int start, int end)
    {
        double mean = values.Mean(start, end);
        double variance = values.Variance(mean, start, end);
        return Math.Sqrt(variance);
    }
}
}

/*
Mean : 3.5  Variance : 2.916666666667  S.D = 1.7078251256993