/*
 *  C# Program to Declare and Instantiate Delegates
 */
using System;
delegate void dele1();
public class Delegateintro
{
    static void Main()
    {
        dele1 del = new dele1(Write);
        del();
    }
    static void Write()
    {
        Console.WriteLine("Calling Write  ");
    }
}