/*
 * C# Program to Interchange any 2 Rows of a Matrix
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class interchangerow
{
    int m, n;
    int[,] a;
    public interchangerow(int x, int y)
    {
        m = x;
        n = y;
        a = new int[m, n];
    }
    public void readmatrix()
    {
        Console.WriteLine("Enter the Elements : ");
        for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("a[{0},{1}]=", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
            }
    }
    public void printmax()
    {
        Console.WriteLine("Given Matrix : ");
        for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}\t", a[i, j]);
                    }
                Console.WriteLine();
            }
    }
    public void interchange()
    {
        Console.WriteLine("Enter the Row Number to Interchange : ");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Row Number with which Interchange is to be Accomplished :");
        int j = Convert.ToInt32(Console.ReadLine());
        for (int k = 0; k < n; k++)
            {
                int temp = a[i - 1, k];
                a[i - 1, k] = a[j - 1, k];
                a[j - 1, k] = temp;
            }
    }
    public static void Main()
    {
        int x, y;
        interchangerow obj;
        Console.Write("Enter the Number of Rows");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Number of Columns");
        y = Convert.ToInt32(Console.ReadLine());
        obj = new interchangerow(x, y);
        obj.readmatrix();
        obj.printmax();
        obj.interchange();
        obj.printmax();
        Console.ReadLine();
    }
}

/*
Enter the Number of Rows : 3
Enter the Number of Columns : 3
Enter the Elements :
a[0,0]=1
a[0,1]=2
a[0,2]=3
a[1,0]=4
a[1,1]=5
a[1,2]=6
a[2,0]=7
a[2,1]=8
a[2,2]=9
Given Matrix is :
1  2  3
4  5  6
7  8  9
Enter the Row Number to Interchange : 2
Enter the Row Number with which Interchange is to be Accomplished : 3
Given Matrix is :
1  2  3
7  8  9
4  5  6