/*
 * C# Program to find Product of 2 Numbers using Recursion
 */
using System;
class program
{
    public static void Main()
    {
        int a, b, result;
        Console.WriteLine("Enter two numbers to find their product: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        prog pg = new prog();
        result = pg.product(a, b);
        Console.WriteLine("Product of {0} and {1} is {2}",a, b, result);
        Console.ReadLine();
    }
}
class prog
{
    public int product(int a, int b)
    {
        if (a < b)
            {
                return product(b, a);
            }
        else if (b != 0)
            {
                return (a + product(a, b - 1));
            }
        else
            {
                return 0;
            }
    }
}

/*
Enter two numbers to find their product:
5
6
Product of 5 and 6 is 30