/*
 * C# Program to Check If a Given Matrix is an Identity Matrix
 */
using System;
class pro
{
    public static void Main()
    {
        Console.WriteLine("Enter the order: ");
        int n = int.Parse(Console.ReadLine());
        int[,] a = new int[3, 3];
        int i, j;
        Console.WriteLine("\n Enter the matrix\n");
        for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    {
                        a[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
            }
        for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    {
                        if ((i == j && a[i, j] != 1) || (i != j && a[i, j] != 0))
                            {
                                goto label;
                            }
                    }
            }
        Console.WriteLine("Identity Matrix");
        return;
label:
        Console.WriteLine("\n Not an Identity Matrix");
    }
}

/*
Enter the Order : 2
Enter the Matrix :
1
0
0
1
Identity Matrix