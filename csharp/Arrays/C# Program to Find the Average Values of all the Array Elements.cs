/*
 * C# Program to Find the Average Values of all the Array Elements
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program
{
    public void sumAverageElements(int[] arr, int size)
    {
        int sum = 0;
        int average = 0;
        for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
        average = sum / size;
        Console.WriteLine("Sum Of Array is : " + sum);
        Console.WriteLine("Average Of Array is : " + average);
        Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        int size;
        Console.WriteLine("Enter the Size :");
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter the Elements of the Array : ");
        for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        int len = a.Length;
        program pg = new program();
        pg.sumAverageElements(a, len);
    }
}

/*
Enter the Size :
5
Enter the Elements of the Array :
10
20
30
40
50
Sum of the Array is : 150
Average of the Array is : 30