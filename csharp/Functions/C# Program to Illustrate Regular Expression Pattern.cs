/*
 * C# Program to Illustrate Regular Expression Pattern
 */
using System;
using System.Text.RegularExpressions;
namespace Application
{
class Program
{
    private static void showMatch(string text, string expr)
    {
        Console.WriteLine("The Expression : " + expr);
        MatchCollection m = Regex.Matches(text, expr);
        foreach (Match m1 in m)
            {
                Console.WriteLine(m1);
            }
    }
    static void Main(string[] args)
    {
        string str = "Sanfoundry , a high end Technology Training company";
        Console.WriteLine("Matching words that start with 'S': ");
        showMatch(str, @"\bS\S*");
        Console.ReadKey();
    }
}
}

/*

Matching Words that Starts With 'S' :
The Expression : \bs\s*
Sanfoundry