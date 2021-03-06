// Example for String.Compare(String, Int32, String, Int32, Int32, Boolean, CultureInfo)
using System;
using System.Globalization;

class Example23
{
    public static void Main()
    {
//                 01234567
        String str1 = "COMPUTER";
        String str2 = "computer";
        String str;
        int result;
        Console.WriteLine();
        Console.WriteLine("\n str1 = '{0}', str2 = '{1}'", str1, str2);
        Console.WriteLine("Ignore case, Turkish culture:");
        result = String.Compare(str1, 4, str2, 4, 2, true, new CultureInfo("tr-TR"));
        str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
        Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(4, 2), str1);
        Console.Write("{0} ", str);
        Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(4, 2), str2);
        Console.WriteLine();
        Console.WriteLine("Ignore case, invariant culture:");
        result = String.Compare(str1, 4, str2, 4, 2, true, CultureInfo.InvariantCulture);
        str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
        Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(4, 2), str1);
        Console.Write("{0} ", str);
        Console.WriteLine("substring '{0}' in '{1}'.\n\n", str2.Substring(4, 2), str2);
    }
}