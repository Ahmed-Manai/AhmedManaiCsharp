/*
 * C# Program to Implement Multicast Delegates
 */
using System;
delegate void dele(int a, int b);
public class Oper
{
    public static void Add(int a, int b)
    {
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }

    public static void Sub(int a, int b)
    {
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
    }
}
public class program
{
    static void Main()
    {
        dele del = new dele(Oper.Add);
        del += new dele(Oper.Sub);
        del(4, 2);
        del -= new dele(Oper.Sub);
        del(1, 9);
        Console.Read();
    }
}
/*

4 + 2 = 6
4 - 2 = 2
1 + 9 = 10