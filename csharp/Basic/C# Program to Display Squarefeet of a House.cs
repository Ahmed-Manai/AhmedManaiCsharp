/*
 * C# Program to Display Squarefeet of a House
 */
using System;
class pgm
{
    public static void Main()
    {
        int length, width, area;
        Console.Write ("Enter length of room in feet: ");
        length = Convert.ToInt32 (Console.ReadLine());
        Console.Write ( "Enter width of room in feet:");
        width = Convert.ToInt32(Console.ReadLine());
        area = length * width;
        Console.WriteLine ("Floor is " + area +  " square feet.");
        Console.ReadLine();
    }
}

/*
Enter Length of Room in Feet : 20
Enter width of Room in Feet : 20
Floor is 400 square feet.