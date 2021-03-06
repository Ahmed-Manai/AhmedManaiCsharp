/*
 *C# Program to Print the Sum of all the Multiples of 3 and 5
 */
using System;
class program
{
    public static void Main()
    {
        int a, b, i, Sum = 0;
        for (i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                    {
                        Console.Write("{0}\t", i);
                        Sum = Sum + i;
                    }
            }
        Console.WriteLine("\nThe Sum of all the Multiples of 3 or 5 Below 100 : {0}", Sum);
        Console.Read();
    }
}

/*
3  5  6  9  10  12  15  18  20  21  24  25  27  30  33  35  36  39  40  42  45  48 50  51  54  55  57  60  63  65  66  69  70  72  75  78  80  81  84  85  87  90  93  95  96  99
The Sum of all the Multiples of 3 or 5 Below 100 : 2318