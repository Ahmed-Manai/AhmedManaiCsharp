using System;
using System.Collections.Generic;

namespace Bogo_sort
{
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>()
        {
            2, 1, 3, 0
        };
        Console.WriteLine("Sorting...");
        Bogo_sort(list, true, 5);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static void Bogo_sort(List<int> list, bool announce, int delay)
    {
        int iteration = 0;
        while (!IsSorted(list))
            {
                if (announce)
                    {
                        Print_Iteration(list, iteration);
                    }
                if (delay != 0)
                    {
                        System.Threading.Thread.Sleep(Math.Abs(delay));
                    }
                list = Remap(list);
                iteration++;
            }
        Print_Iteration(list, iteration);
        Console.WriteLine();
        Console.WriteLine("Bogo_sort completed after {0} iterations.", iteration);
    }

    static void Print_Iteration(List<int> list, int iteration)
    {
        Console.Write("Bogo_sort iteration {0}: ", iteration);
        for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                    {
                        Console.Write(" ");
                    }
            }
        Console.WriteLine();
    }
    static bool IsSorted(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                    {
                        return false;
                    }
            }
        return true;
    }

    static List<int> Remap(List<int> list)
    {
        int temp;
        List<int> newList = new List<int>();
        Random r = new Random();
        while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }
        return newList;
    }
}
}