/*
 * C# Program to Read Lines from a File until the End of File is Reached
 */
using System;
using System.IO;
class Test
{
    public static void Main()
    {
        string path = @"c:\sri\srip.txt";
        try
            {
                if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("text is");
                    sw.WriteLine("to test");
                    sw.WriteLine("Reading");
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                }
            }
        catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        Console.Read();
    }
}

/*
This
text is
to test
reading