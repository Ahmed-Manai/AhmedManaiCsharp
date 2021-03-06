/*
 *  C# Program to Implement Arithmetic Operations using Delegates
 */
using System;
delegate int NumberChanger(int n);
namespace example
{
class Delegate
{
    static int num = 10;
    public static int AddNum(int a)
    {
        num += a;
        return num;
    }

    public static int MultNum(int b)
    {
        num *= b;
        return num;
    }
    public static int getNum()
    {
        return num;
    }

    static void Main(string[] args)
    {
        NumberChanger n1 = new NumberChanger(AddNum);
        NumberChanger n2 = new NumberChanger(MultNum);
        n1(25);
        Console.WriteLine("Value of Num: {0}", getNum());
        n2(5);
        Console.WriteLine("Value of Num: {0}", getNum());
        Console.ReadKey();
    }
}
}
/*

Value of Num: 35
Value of Num: 175