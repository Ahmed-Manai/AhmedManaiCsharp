using System;
using System.Globalization;

class Example27
{
    public static void Main()
    {
        String str1 = "change";
        String str2 = "dollar";
        String relation = null;
        relation = symbol( String.Compare(str1, str2, false, new CultureInfo("en-US")) );
        Console.WriteLine("\nFor en-US: {0} {1} {2}", str1, relation, str2);
        relation = symbol( String.Compare(str1, str2, false, new CultureInfo("cs-CZ")) );
        Console.WriteLine("For cs-CZ: {0} {1} {2}\n", str1, relation, str2);
    }

    private static String symbol(int r)
    {
        String s = "=";
        if      (r < 0) s = "<";
        else if (r > 0) s = ">";
        return s;
    }
}