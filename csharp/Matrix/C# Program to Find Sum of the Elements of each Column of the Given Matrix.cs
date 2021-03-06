/*
 * C# Program to Find Sum of the Elements of each Column
 * of the Given Matrix
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace matrix_col
{
class mat
{
    int i, j, m, n;
    int[,] a = new int[20, 20];
    int[,] c = new int[20, 20];
    public void getmatrix()
    {
        Console.WriteLine("Enter the Number of Rows : ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Number of Columns : ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Elements");
        for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
            }
        Console.WriteLine("Given Matrix");
        for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                    {
                        Console.Write("\t{0}", a[i, j]);
                    }
                Console.WriteLine();
            }
    }

    public void col()
    {
        int c;
        for (i = 1; i <= n; i++)
            {
                c = 0;
                for (j = 1; j <= m; j++)
                    {
                        c = c + a[j, i];
                    }
                Console.WriteLine("{0} Column Sum : {1}", i, c);
            }
    }
}
class matsum
{
    static void Main(string[] args)
    {
        mat ma = new mat();
        ma.getmatrix();
        ma.col();
        Console.ReadLine();
    }
}
}

/*
Enter the Number of Rows : 2
Enter the Number of Columns : 2
Enter the Elements :
1
2
3
4
Given Matrix :
        1      2
        3      4
1 Column Sum : 4
2 Column Sum : 6