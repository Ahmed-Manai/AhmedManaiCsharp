/*
 * C# Program to Illustrate Bitwise Operations
 */
using System;
class bitwise
{
    byte b1, b2;
    int x;
    long y;
    bitwise()
    {
        b1 = 10;
        b2 = 5;
        x = 32;
        y = 20;
    }
    public static void Main()
    {
        bitwise bit = new bitwise();
        byte p = (byte)(bit.b1 & bit.b2);
        byte q = (byte)(bit.b1 | bit.b2);
        byte r = (byte)(bit.b1 ^ bit.b2);
        int z = (int)(bit.x & bit.y);
        Console.WriteLine("b1={0},b2={1},x={2},y={3}", bit.b1, bit.b2, bit.x, bit.y);
        Console.WriteLine("b1 & b2={0} : ", p);
        Console.WriteLine("b1 | b2={0} : ", q);
        Console.WriteLine("b1 ^ b2={0} : ", r);
        Console.WriteLine("x & y = {0} : ", z);
        Console.ReadLine();
    }
}

/*
b1=10,b2=5,x=32,y=20
b1 & b2 : 0
b1 | b2 : 15
b1 ^ b2 : 15
x & y :0