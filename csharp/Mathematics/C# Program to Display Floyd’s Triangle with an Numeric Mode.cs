/*
 *  C# Program to Display Floyd's Triangle with an Numeric Mode
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        int i, j, k = 1;
        for (i = 1; i <= 10; i++)
            {
                for (j = 1; j < i + 1; j++)
                    {
                        Console.Write(k++ + " ");
                    }
                Console.Write("\n");
            }
        Console.ReadLine();
    }
}

/*
1
2 3
4 5 6
7 8 9 10
11 12 13 14 15
16 17 18 19 20 21
22 23 24 25 26 27 28
29 30 31 32 33 34 35 36
37 38 39 40 41 42 43 44 45
46 47 48 49 50 51 52 53 54 55