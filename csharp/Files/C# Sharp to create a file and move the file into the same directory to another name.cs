using System;
using System.IO;
using System.Text;


public class SimpleFileMove
{
    static void Main()
    {
        string sfileName = @"mytest.txt";
        string tfileName = @"mynewtest.txt";
        /*      string sourcefolder = "path";  // you can mention the path of source folder
        		string targetfolder = "path"; // you can mention the path of target folder
        		string sourceFile = System.IO.Path.Combine(sourcefolder, sfileName); // combine the source file with path
        		string targetFile = System.IO.Path.Combine(targetfolder, tfileName);   // combine the target file with path */
        if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
        if (File.Exists(tfileName))
            {
                File.Delete(tfileName);
            }
        Console.Write("\n\n Create a file and move the file in same folder to another name  :\n");
        Console.Write("----------------------------------------------------------------------\n");
        // Create the file.
        using (StreamWriter fileStr = File.CreateText(sfileName))
        {
            fileStr.WriteLine(" Hello and Welcome");
            fileStr.WriteLine(" It is the first content");
            fileStr.WriteLine(" of the text file mytest.txt");
        }
        using (StreamReader sr = File.OpenText(sfileName))
        {
            string s = "";
            Console.WriteLine(" Here is the content of the file {0} : ",sfileName);
            while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            Console.WriteLine("");
        }
        System.IO.File.Move(sfileName, tfileName); // move a file to another name in same location:
        Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.",sfileName,tfileName );
        using (StreamReader sr = File.OpenText(tfileName))
        {
            string s = "";
            Console.WriteLine(" Here is the content of the file {0} : ",tfileName);
            while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            Console.WriteLine("");
        }
        Console.ReadKey();
    }
}