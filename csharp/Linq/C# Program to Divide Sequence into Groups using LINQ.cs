/*
 * C# Program to Divide Sequence into Groups using LINQ
 */
using System;
using System.Linq;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        var seq = Enumerable.Range(100, 100).Select(x => x / 10f);
        var grps = from x in seq.Select((i, j) => new
        {
            i, Grp = j / 10
        })
        group x.i by x.Grp into y
        select new { Min = y.Min(), Max = y.Max() };
        foreach (var grp in grps)
            Console.WriteLine("Min: " + grp.Min + " Max:" + grp.Max);
        Console.ReadLine();
    }
}

/*
Min : 10  Max : 10.9
Min : 11  Max : 11.9
Min : 12  Max : 12.9
Min : 13  Max : 13.9
Min : 14  Max : 14.9
Min : 15  Max : 15.9
Min : 16  Max : 16.9
Min : 17  Max : 17.9
Min : 18  Max : 18.9
Min : 19  Max : 19.9