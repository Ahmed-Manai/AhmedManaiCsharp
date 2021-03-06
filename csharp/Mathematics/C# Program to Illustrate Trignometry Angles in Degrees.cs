/*
 * C# Program to Illustrate Trignometry Angles in Degrees
 */
using System;
namespace trig
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trignometric values in Degree");
        Console.WriteLine("sin (60)     = {0}", Math.Sin(60 * Math.PI / 180));
        Console.WriteLine("cos (60)     = {0}", Math.Cos(60 * Math.PI / 180));
        Console.WriteLine("tan (60)     = {0}", Math.Tan(60 * Math.PI / 180));
        Console.WriteLine("arcsin (1/2) = {0}", Math.Asin(0.5) * 180 / Math.PI);
        Console.WriteLine("arccos (1/2) = {0}", Math.Acos(0.5) * 180 / Math.PI);
        Console.WriteLine("arctan (1/2) = {0}", Math.Atan(0.5) * 180 / Math.PI);
        Console.Read();
    }
}
}

/*
Trignometric Values in Radians :
sin (pi/3)   = 0.866025403784439
cos (pi/3)   = 0.5
tan (pi/3)   = 1.73205080756888
arcsin (1/2) = 30
arccos (1/2) = 60
arctan (1/2) = 26.565051177078