C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20.

    using System;
public class Exercise11
{
    public static void Main()
    {
        int age;
        Console.Write("Enter your age ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("You look younger than {0} ",age);
    }
}