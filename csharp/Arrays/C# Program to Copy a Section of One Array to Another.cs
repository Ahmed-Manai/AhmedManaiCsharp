/*
 * C# Program to Copy a Section of One Array to Another
 */
using System;
class Program
{
    static void Main()
    {
        int n, m, size;
        Console.WriteLine("Enter the size of the Array : ");
        n = Convert.ToInt32(Console.ReadLine());
        int [] a = new int[n];
        Console.WriteLine("Enter the Elements of the First Array :");
        for (int i = 0; i <n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine("Enter the Size of the Target Array : ");
        m = Convert.ToInt32(Console.ReadLine());
        int[] target = new int[m];
        Console.WriteLine("Enter the section of the First Array that has to be Copied :");
        size = Convert.ToInt32(Console.ReadLine());
        Array.Copy(a, 0, target, 0, size);
        Console.WriteLine("New Array With The Specified Section of Elements in the First Array");
        foreach (int value in target)
            {
                Console.WriteLine(value);
            }
        Console.Read();
    }
}

/*
Enter the size of the Array : 5
Enter the Elements of the First Array :
1
2
3
4
5
Enter the Size of the Target Array :
6
Enter the section of the First Array that has to be Copied : 3
New Array With The Specified Section of Elements in the First Array :
1
2
3
0
0
0