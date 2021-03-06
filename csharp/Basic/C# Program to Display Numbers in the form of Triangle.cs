/*
 *  C# Program to Display Numbers in the form of Triangle
 */
using System;
class Pascal
{
    public static void Main()
    {
        int[,] arr = new int[8, 8];
        for (int i = 0; i < 8; i++)
            {
                for (int k = 7; k > i; k--)
                    {
                        //For loop to print spaces
                        Console.Write(" ");
                    }
                for (int j = 0; j < i; j++)
                    {
                        if (j == 0 || i == j)
                            {
                                arr[i, j] = 1;
                            }
                        else
                            {
                                arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                            }
                        Console.Write(arr[i, j] + " ");
                    }
                Console.WriteLine();
            }
        Console.ReadLine();
    }
}

/*
      1
     1 1
    1 2 1
   1 3 3 1
  1 4 6 4 1
 1 5 10 10 5 1
1 6 15 20 15 6 1