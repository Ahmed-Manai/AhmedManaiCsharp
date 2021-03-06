/*
Write a C# Sharp program to compares four sets of words by using each member of the StringComparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.
Note: that the strings "encyclopedia" and "encyclopedia" are considered equivalent in the en-US culture but not in the Sami (Northern Sweden) culture.
*/

using System;
using System.Globalization;
using System.Threading;

public class Example25
{
    public static void Main()
    {
        String[] cultureNames = { "en-AU", "sv-SE" };
        String[] strs1 = { "case",  "encyclopedia",
                           "encyclopedia", "Archeology"
                         };
        String[] strs2 = { "Case", "encyclopedia",
                           "encyclopedia", "ARCHEOLOGY"
                         };
        StringComparison[] comparisons = (StringComparison[]) Enum.GetValues(typeof(StringComparison));
        foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                    {
                        foreach (var comparison in comparisons)
                            Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                                              strs2[ctr], comparison,
                                              String.Equals(strs1[ctr], strs2[ctr], comparison));
                        Console.WriteLine();
                    }
                Console.WriteLine();
            }
    }
}