/*
 * C# Program to Display All the Prime Numbers Between 1 to 100
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PrimeNumber
{
class Program
{
    static void Main(string[] args)
    {
        bool isPrime = true;
        Console.WriteLine("Prime Numbers : ");
        for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                    {
                        if (i != j && i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                    }
                if (isPrime)
                    {
                        Console.Write("\t" +i);
                    }
                isPrime = true;
            }
        Console.ReadKey();
    }
}
}

/*
Prime Numbers :
      2 3 5 7 11 13 17 19 23 29
31 37 41 43 47 53 59 61 67 71
73 79 83 89 97