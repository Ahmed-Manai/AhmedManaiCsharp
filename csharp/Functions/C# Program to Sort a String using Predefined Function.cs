/*
 * C# Program to Sort a String using Predefined Function
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
        Console.WriteLine("Enter Array Elements :");
        for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        Array.Sort(a);
        Console.WriteLine("Sorted Array : ");
        for (int i = 0; i < x; i++)
            {
                Console.WriteLine("{0}",a[i]);
            }
        Console.Read();
    }
}

/*
Enter Number of Elements you Want to Hold in the Array ? 5
Enter Array Elements :
2
3
1
4
5
Sorted Array :
1
2
3
4
5