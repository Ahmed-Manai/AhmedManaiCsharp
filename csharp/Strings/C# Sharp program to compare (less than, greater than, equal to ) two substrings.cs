// Example for String.Compare(String, Int32, String, Int32, Int32)
using System;

class Example21
{
    public static void Main()
    {
//                 01234567
        String str1 = "computer";
        String str2 = "system";
        String str;
        int result;
        Console.WriteLine();
        Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
        result = String.Compare(str1, 2, str2, 0, 2);
        str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
        Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
        Console.Write("{0} ", str);
        Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(0, 2), str2);
    }
}