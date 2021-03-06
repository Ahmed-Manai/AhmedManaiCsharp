using System;

class Example26
{
    static void Main()
    {
        // Create upper-case characters from their Unicode code units.
        String stringUpper = "\x0051\x0052\x0053";
        // Create lower-case characters from their Unicode code units.
        String stringLower = "\x0071\x0072\x0073";
        // Display the strings.
        Console.WriteLine("Comparing '{0}' and '{1}':",
                          stringUpper, stringLower);
        // Compare the uppercased strings; the result is true.
        Console.WriteLine("The Strings are equal when capitalized? {0}",
                          String.Compare(stringUpper.ToUpper(), stringLower.ToUpper()) == 0
                          ? "true" : "false");
        // The previous method call is equivalent to this Compare method, which ignores case.
        Console.WriteLine("The Strings are equal when case is ignored? {0}",
                          String.Compare(stringUpper, stringLower, true) == 0
                          ? "true" : "false" );
    }
}