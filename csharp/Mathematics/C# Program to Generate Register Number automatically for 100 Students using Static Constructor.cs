/*
 * C# Program to Generate Register Number automatically for 100 Students using Static Constructor
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace staticprog
{
class sample
{
    int regnumber;
    static int nextnum;
    static sample()
    {
        nextnum=1000;
    }
    sample()
    {
        regnumber=++nextnum;
    }
    public static void Main(string[] args)
    {
        sample s=new sample();
        Console.WriteLine("#1 : {0}",s.regnumber);
        s=new sample();
        Console.WriteLine("#2 : {0}",s.regnumber);
        s = new sample();
        Console.WriteLine("#3 : {0}", s.regnumber);
        Console.ReadLine();
    }
}
}

/*
#1 : 1001
#2 : 1002
#3 : 1003