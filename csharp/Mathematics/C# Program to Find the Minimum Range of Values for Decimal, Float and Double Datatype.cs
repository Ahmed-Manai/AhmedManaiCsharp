/*
 * C# Program to Find the Minimum Range of Values for Decimal,Float and Double Datatype
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace maxdatatype
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Minimum Range of the Decimal Data Type is : {0} ",Decimal.MaxValue);
        Console.WriteLine("The Minimum Range of the Float Data Type is : {0} ",Single.MaxValue);
        Console.WriteLine("The Minimum Range of the Decimal Data Type is : {0} ",Double.MaxValue);
        Console.WriteLine("Exponent Form : The Minimum Range of Decimal Data Type  is : {0:E}", Decimal.MaxValue);
        Console.WriteLine("Exponent Form : The Minimum Range of Float Data Type  is : {0:E}", Single.MaxValue);
        Console.WriteLine("Exponent Form : The Minimum Range of Double Data Type  is : {0:E}", Double.MaxValue);
        Console.ReadLine();
    }
}
}

/*
The Minimum Range of the Decimal Data Type is : -7922816251464337593543950335
The Minimum Range of the Float Data Type is : -3.40282347E+38
The Minimum Range of the Double Data Type is : -1.7976931348623157E+308
Exponent Form : The Minimum Range of Decimal Data Type  is : -7.922816E+028
Exponent Form : The Minimum Range of Float Data Type  is : -3.402823E+038
Exponent Form : The MinimumRange of Decimal Data Type  is : -1.797693E+308