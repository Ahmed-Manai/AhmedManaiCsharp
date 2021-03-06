/*
 * C# Program to Generate the Transpose of a Given Matrix
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
class Program
{
    public static void Main(string[] args)
    {
        int m, n, i, j;
        Console.Write("Enter the Order of the Matrix : ");
        m = Convert.ToInt16(Console.ReadLine());
        n = Convert.ToInt16(Console.ReadLine());
        int[,] A = new int[10, 10];
        Console.Write("\nEnter The Matrix Elements : ");
        for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    {
                        A[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
            }
        Console.Clear();
        Console.WriteLine("\nMatrix A : ");
        for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    {
                        Console.Write(A[i, j] + "\t");
                    }
                Console.WriteLine();
            }
        Console.WriteLine("Transpose Matrix : ");
        for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    {
                        Console.Write(A[j, i] + "\t");
                    }
                Console.WriteLine();
            }
        Console.Read();
    }
}
}

/*
Enter the Order of the Matrix : 2  2
Enter the Matrix Elements :
1 2
3 4
Matrix A :
1 2
3 4
Transpose Matrix :
1 3
2 4