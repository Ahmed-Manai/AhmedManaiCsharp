/*
 * C# Program to Reverse an Array
 */
using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3,4,5,6,7,8,9,10 };
        foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        Array.Reverse(array);
        Console.WriteLine("Reversed Array : ");
        foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        Console.ReadLine();
    }
}

/*
1
2
3
4
5
6
7
8
9
10
Reversed Array :
10
9
8
7
6
5
4
3
2
1