/*
 * C# Program to Illustrate StringBuilder
 */
using System;
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder bd = new StringBuilder();
        bd.Append("1 ");
        bd.Append("2 ");
        bd.Append("3 ");
        for (int i = 0; i < 5; i++)
            {
                bd.Append("z ");
            }
        string result = bd.ToString();
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

/*
1 2 3 z z z z z