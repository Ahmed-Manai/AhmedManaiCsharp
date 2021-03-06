/*
 *  C# Program to Search an element with Array Indices
 */
using System;

class ArrayBinarySearch
{
    public static void Main()
    {
        int[] ints = { 0, 10, 100, 1000, 1000000 };
        Console.WriteLine("Array indices and elements: ");
        for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("[{0}]={1, -5}", i, ints[i]);
            }
        Console.WriteLine();
        FindObject(ints, 25);
        FindObject(ints, 1000);
        FindObject(ints, 2000000);
        Console.ReadLine();
    }

    public static void FindObject(Array array, Object o)
    {
        int index = Array.BinarySearch(array, 0, array.Length, o);
        Console.WriteLine();
        if (index > 0)
            {
                Console.WriteLine("Object: {0} found at [{1}]", o, index);
            }
        else if (~index == array.Length)
            {
                Console.WriteLine("Object: {0} not found. "
                                  + "No array object has a greater value.", o);
                Console.WriteLine();
            }
        else
            {
                Console.WriteLine("Object: {0} not found. "
                                  + "Next larger object found at [{1}].", o, ~index);
            }
    }
}

/*
Array indices and elements:
[0]=0    [1]=10   [2]=100  [3]=1000 [4]=1000000
Object: 25 not found. Next larger object found at [2].
Object: 1000 found at [3]
Object: 2000000 not found. No array object has a greater value.