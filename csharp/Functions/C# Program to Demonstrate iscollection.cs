/*
 *  C# Program to Demonstrate iscollection.synchronised
 */
using System;
using System.Collections;

public class CountArray
{
    public static void Main()
    {
        string[] strings = { "Ajax", "Atlas" };
        DisplayCollectionProperty(strings);
        Console.ReadLine();
    }

    public static void DisplayCollectionProperty
    (ICollection iCollection)
    {
        Console.WriteLine("IsSynchronized: {0}",
                          iCollection.IsSynchronized);
    }
}

/*

IsSynchronized: False