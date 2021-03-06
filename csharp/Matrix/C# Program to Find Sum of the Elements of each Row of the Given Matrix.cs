/*
 * C# Program to Find Sum of the Elements of each Row
 * of the Given Matrix
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace matrix_row_sum
{
class mat
{
    int i, j, m, n;
    int[,] a = new int[20, 20];
    public void getmatrix()
    {
        Console.WriteLine("Enter The Number of Rows : ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter The Number of Columns : ");
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
    public void row()
    {
        int r;
        for (i = 1; i <= m; i++)
            {
                r = 0;
                for (j = 1; j <= n; j++)
                    {
                        r = r + a[i, j];
                    }
                Console.WriteLine("{0} Row Sum : {1}", i, r);
            }
    }
}
class matrowsum
{
    static void Main(string[] args)
    {
        mat ma = new mat();
        ma.getmatrix();
        ma.row();
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
1 Row Sum : 3
2 Row Sum : 7