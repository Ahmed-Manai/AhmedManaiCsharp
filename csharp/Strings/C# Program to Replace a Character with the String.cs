/*
 * C# Program to Replace a Character with the String
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        string s = "".PadLeft(5, 'X').Replace("X", "Sanfoundry");;
        Console.Write("The String After the Replacement :{0}",s);
        Console.Read();
    }

}

/*
The String After the Replacement :SanfoundrySanfoundrySanfoundrySanfoundrySanfoundry