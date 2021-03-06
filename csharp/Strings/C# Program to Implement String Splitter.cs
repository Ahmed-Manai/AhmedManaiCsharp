/*
 * C# Program to Implement String Splitter
 */
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string sentence = "School had 40 Rooms, 500 Boys, 500 Girls and 250 Teachers";
        string[] digits = Regex.Split(sentence, @"\D+");
        foreach (string value in digits)
            {
                int number;
                if (int.TryParse(value, out number))
                    {
                        Console.Write(value);
                    }
                Console.ReadLine();
            }
    }
}

/*
40
500
500
250