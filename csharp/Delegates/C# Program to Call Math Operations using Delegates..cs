/*
 *  C# Program to Call Math Operations using Delegates
 */

using System;
public class MathOperations
{
    public static double Multiply(double value)
    {
        return value * 2;
    }

    public static double Square(double value)
    {
        return value * value;
    }
}


delegate double DoubleOp(double x);

class Application
{
    static void Main()
    {
        DoubleOp[] operations =
        {
            MathOperations.Multiply,
            MathOperations.Square
        };
        for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Operation[{0}]:", i);
                ProcessAndDisplayNumber(operations[i], 5.0);
                ProcessAndDisplayNumber(operations[i], 13.55);
                ProcessAndDisplayNumber(operations[i], 1.732);
                Console.WriteLine();
            }
        Console.ReadLine();
    }

    static void ProcessAndDisplayNumber(DoubleOp action, double value)
    {
        double result = action(value);
        Console.WriteLine(
            "Value : {0}  Result : {1}", value, result);
    }
}
/*

Operation[0]:
Value : 5  Result : 10
Value : 13.55  Result : 27.1
Value : 1.732  Result : 3.464

Operation[1]:
Value : 5  Result : 25
Value : 13.55  Result : 183.6025
Value : 1.732  Result : 2.999824