/*
 *  C# Program to Display the Smallest numbers in an Array using FROM Clause LINQ
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
class program
{
    static void Main()
    {
        int[] numbers = { 50,30,45,10,60,100,500,300,40,22,44,55,66,1000 };
        var program = from num in numbers
                      where num < 50
                      select num;
        Console.WriteLine("Numbers less than 50 are :");
        foreach (int i in program)
            {
                Console.Write(i + " ");
            }
        Console.ReadLine();
    }
}
}

/*
Numbers less than 50 are :
30 45 10 40 22 44