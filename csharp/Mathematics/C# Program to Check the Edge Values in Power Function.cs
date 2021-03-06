/*
 *  C# Program to Check the Edge Values in Power Function
 */
using System;
class Program
{
    static void Main()
    {
        double value1 = Math.Pow(double.MinValue, double.MaxValue);
        double value2 = Math.Pow(double.MinValue, 0);
        double value3 = Math.Pow(double.NaN, 2);
        double value4 = Math.Pow(double.PositiveInfinity, 2);
        double value5 = Math.Pow(double.NegativeInfinity, 2);
        Console.WriteLine("Result : {0}", value1);
        Console.WriteLine("Result : {0}", value2);
        Console.WriteLine("Result : {0}", value3);
        Console.WriteLine("Result : {0}", value4);
        Console.WriteLine("Result : {0}", value5);
        Console.ReadLine();
    }
}

/*
Result : Infinity
Result : 1
Result : NaN
Result : Infinity
Result : Infinity