/*
 * C# Program to Find Largest Element in a Matrix
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class arrsampl
{
    int[,]x;
    arrsampl()
    {
        x = new int[,] { { 12, 21, 63 }, { 40, 15, 6 } };
    }
    void printarray()
    {
        Console.WriteLine("Elements in the Given Matrix : ");
        for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    {
                        Console.Write(x[i, j] + "\t");
                    }
                Console.WriteLine("\n");
            }
    }
    int max()
    {
        int big = x[0, 0];
        for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    {
                        if (big < x[i, j])
                            {
                                big = x[i, j];
                            }
                    }
            }
        return big;
    }
    public static void Main()
    {
        arrsampl obj = new arrsampl();
        obj.printarray();
        Console.WriteLine("Largest Element : {0}", obj.max());
        Console.ReadLine();
    }
}

/*
Elements in the Given Matrix :
12 21 63
40 15 6
Largest Element : 63