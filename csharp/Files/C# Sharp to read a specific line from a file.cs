using System;
using System.IO;


class filexercise13
{
    static void Main()
    {
        string fileName = @"mytest.txt";
        string[] ArrLines ;
        int n,i,l;
        Console.Write("\n\n Read a specific line from a file  :\n");
        Console.Write("----------------------------------------\n");
        if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        Console.Write(" Input number of lines to write in the file  :");
        n= Convert.ToInt32(Console.ReadLine());
        ArrLines=new string[n];
        Console.Write(" Input {0} strings below :\n",n);
        for(i=0; i<n; i++)
            {
                Console.Write(" Input line {0} : ",i+1);
                ArrLines[i] = Console.ReadLine();
            }
        System.IO.File.WriteAllLines(fileName, ArrLines);
        Console.Write("\n Input which line you want to display  :");
        l = Convert.ToInt32(Console.ReadLine());
        if(l>=1 && l<=n)
            {
                Console.Write("\n The content of the line {0} of the file {1} is : \n",l,fileName);
                if (File.Exists(fileName))
                    {
                        string[] lines = File.ReadAllLines(fileName);
                        Console.WriteLine(" {0}",lines[l-1]);
                    }
            }
        else
            {
                Console.WriteLine(" Please input the correct line no.");
            }
        Console.WriteLine();
    }
}