/*
 * C# Program to Check whether the given Integer has an
 * Alternate Pattern
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program
{
    public static void Main()
    {
        int num, x, y, count = 0;
        Console.WriteLine("Enter the Number:");
        num = int.Parse(Console.ReadLine());
        x = num << 1;
        y = x ^ num;
        y = y + 1;
        while ((y / 2) != 0)
            {
                if (y % 2 != 0)
                    {
                        count++;
                        break;
                    }
                else
                    {
                        y = y / 2;
                    }
            }
        if (count == 1)
            {
                Console.WriteLine("false");
            }
        else
            {
                Console.WriteLine("true");
            }
        Console.Read();
    }
}

/*
Enter the Number: 100
false