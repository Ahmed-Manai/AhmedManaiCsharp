/*
 * C# Program to Perform File Comparison
 */
using System;
using System.Threading;
using System.IO;

class Reader
{
    string fileName;
    public string data;

    public Reader(string fn)
    {
        fileName = fn;
    }

    public void Read()
    {
        FileStream s = new FileStream(fileName, FileMode.Open);
        StreamReader r = new StreamReader(s);
        data = r.ReadToEnd();
        r.Close();
        s.Close();
    }
}
class ThreadSample
{
    static void Main(string[] arg)
    {
        if (arg.Length == 2)
            {
                Reader a = new Reader(arg[0]);
                Reader b = new Reader(arg[1]);
                Thread ta = new Thread(new ThreadStart(a.Read));
                Thread tb = new Thread(new ThreadStart(b.Read));
                ta.Start();
                tb.Start();
                ta.Join();
                tb.Join();
                if (a.data.Length == b.data.Length)
                    {
                        int i = 0;
                        while (i < a.data.Length && a.data[i] == b.data[i]) i++;
                        if (i == a.data.Length)
                            Console.WriteLine("Files {0} and {1} are equal", arg[0], arg[1]);
                        else
                            Console.WriteLine("Files {0} and {1} are not equal", arg[0], arg[1]);
                    }
                else
                    {
                        Console.WriteLine("Files {0} and {1} are not equal", arg[0], arg[1]);
                    }
            }
        else
            {
                Console.WriteLine("-- enter two file names");
            }
        Console.ReadLine();
    }
}

/*
D:\Desktop\c#\program codes>pgno382.exe d:\\sri\\File1.txt d:\\sri\\File1.txt
Files d:\\sri\\File1.txt and d:\\sri\\File1.txt
are equal