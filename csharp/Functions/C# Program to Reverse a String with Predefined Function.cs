/*
 * C# Program to Reverse a String with Predefined Function
 */
using System;
class linSearch
{
    public static void Main()
    {
        Console.WriteLine("Enter Number of Elements you Want to Hold in the Array ? ");
        string s = Console.ReadLine();
        int x = Int32.Parse(s);
        int[] a = new int[x];
        Console.WriteLine("\n Enter Array Elements : ");
        for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        Array.Reverse(a);
        Console.WriteLine("Reversed Array : ");
        for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Element {0} is {1}", i + 1, a[i]);
            }
        Console.Read();
    }
}

/*
Enter Number of Elements you Want to Hold in the Array ? 5
Enter Array Elements : 2
3
4
5
6
Reversed Array :
Element is : 6
Element is : 5
Element is : 4
Element is : 3
Element is : 2