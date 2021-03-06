/*
 * C# Program to Implement IEnumerable Interface using LINQ
 */
using System;
using System.IO;
using System.Collections;
using System.Linq;
class program
{
    public static void Main(string[] args)
    {
        var t = typeof(IEnumerable);
        var typesIEnum = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => t.IsAssignableFrom(x));
        foreach (var types in typesIEnum)
            {
                Console.WriteLine(types.FullName);
            }
        Console.ReadLine();
    }
}
/*

System.Linq.Parallel.IndexedSelectQueryOperator`2
System.Linq.Parallel.IndexedSelectQueryOperator`2+IndexedSelectQueryOperatorResults
System.Linq.Parallel.IndexedWhereQueryOperator`1
System.Linq.Parallel.LastQueryOperator`1
System.Linq.Parallel.ReverseQueryOperator`1
System.Linq.Parallel.ReverseQueryOperator`1+ReverseQueryOperatorResults
System.Linq.Parallel.SelectManyQueryOperator`3
System.Linq.Parallel.SelectQueryOperator`2
System.Linq.Parallel.SelectQueryOperator`2+SelectQueryOperatorResults
System.Linq.Parallel.SingleQueryOperator`1
System.Linq.Parallel.SortQueryOperator`2
System.Linq.Parallel.SortQueryOperatorResults`2
System.Linq.Parallel.TakeOrSkipQueryOperator`1
System.Linq.Parallel.TakeOrSkipQueryOperator`1+TakeOrSkipQueryOperatorResults
System.Linq.Parallel.TakeOrSkipWhileQueryOperator`1
System.Linq.Parallel.WhereQueryOperator`1
System.Linq.Parallel.ListChunk`1
System.Linq.Parallel.Lookup`2