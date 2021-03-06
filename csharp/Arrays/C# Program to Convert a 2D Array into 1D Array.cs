/*
 * C# Program to Convert a 2D Array into 1D Array
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
class twodmatrix
{
    int m, n;
    int[,] a;
    int[] b;
    twodmatrix(int x, int y)
    {
        m = x;
        n = y;
        a = new int[m, n];
        b = new int[m * n];
    }
    public void readmatrix()
    {
        for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("a[{0},{1}]=", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
            }
    }
    public void printd()
    {
        for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}\t", a[i, j]);
                    }
                Console.Write("\n");
            }
    }
    public void convert()
    {
        int k = 0;
        for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    {
                        b[k++] = a[i, j];
                    }
            }
    }
    public void printoned()
    {
        for (int i = 0; i < m * n; i++)
            {
                Console.WriteLine("{0}\t", b[i]);
            }
    }


    public static void Main(string[] args)
    {
        twodmatrix obj = new twodmatrix(2,3);
        Console.WriteLine("Enter the Elements : ");
        obj.readmatrix();
        Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
        obj.printd();
        obj.convert();
        Console.WriteLine("\t\t Converted 1-D Array is : ");
        obj.printoned();
        Console.ReadLine();
    }
}
}

/*
Enter the Elements :
a[0,0]=3
a[0,1]=7
a[0,2]=1
a[1,0]=9
a[1,1]=34
a[1,2]=23
                   Given 2-D Array(Matrix) is :
1  4  3
7  3  8
                  Converted 1-D Array is :
1
4
3
7
3
8