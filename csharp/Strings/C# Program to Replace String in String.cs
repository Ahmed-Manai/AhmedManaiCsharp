/*
 * C# Program to Replace String in String
 */
using System;
class Program
{
    static void Main()
    {
        const string s = "Sun Rises in the West";
        Console.WriteLine("Sentence Before Replacing : {0} ",s);
        string s1 = s.Replace("West", "East");
        Console.WriteLine("Sentence After Replacing : {0} ",s1);
        Console.ReadLine();
    }
}

/*
Sentence Before Replacing : Sun Rises in the West
Sentence After Replacing : Sun Rises in the East