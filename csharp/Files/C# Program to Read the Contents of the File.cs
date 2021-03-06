/*
 * C# Program to Read Contents of a File
 */
using System;
using System.IO;
class FileRead
{
    public void readdata()
    {
        FileStream fs = new FileStream("Myfile.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);//Position the File Pointer at the Beginning of the File
        sr.BaseStream.Seek(0, SeekOrigin.Begin);//Read till the End of the File is Encountered
        string str = sr.ReadLine();
        while (str != null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }
        //Close the Writer and File
        sr.Close();
        fs.Close();
    }
    public static void Main(String[] args)
    {
        FileRead fr = new FileRead();
        fr.readdata();
    }
}

/*
The text which your are reading are read from the file named myfile.txt that is created already.