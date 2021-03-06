using System;
using System.IO;
using System.Text;


public class SimpleFileCopy
{
    static void Main()
    {
        string sfileName = @"mytest.txt";
        string tfileName = @"mynewtest.txt";
        // Delete the file if it exists.
        if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
        Console.Write("\n\n Create a file and copy the file  :\n");
        Console.Write("---------------------------------------\n");
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
        /*      string sourcefolder = "path";  // you can mention the path of source folder
        		string targetfolder =  "path"; // you can mention the path of target folder
        		string sourceFile = System.IO.Path.Combine(sourcefolder, sfileName); // combine the source file with path
        		string targetFile = System.IO.Path.Combine(targetfolder, tfileName);   // combine the target file with path */
        /*		Create a new target folder if not exists
                if (!System.IO.Directory.Exists(targetfolder))
                {
                    System.IO.Directory.CreateDirectory(targetfolder);
                }
        		System.IO.File.Copy(sourceFile, destFile, true); // overwrite the target file if it already exists. */
        System.IO.File.Copy(sfileName, tfileName, true);
        Console.WriteLine(" The file {0} successfully copied to the name {1} in the same directory.",sfileName,tfileName );
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