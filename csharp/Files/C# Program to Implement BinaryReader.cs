/*
 * C# Program to Implement BinaryReader
 */
using System;
using System.IO;
class ConsoleApplication
{
    const string fileName = "program.dat";
    static void Main()
    {
        Write();
        Console.WriteLine("Using Binary Writer Class the Contents are Written ");
        Display();
    }
    public static void Write()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
        {
            writer.Write(1.250F);
            writer.Write(@"C:\Temp");
        }
    }
    public static void Display()
    {
        float aspectRatio;
        string tempDirectory;
        if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                }
                Console.WriteLine("Aspect Ratio Set to : " + aspectRatio);
                Console.WriteLine("Temp Directory is : " + tempDirectory);
                Console.Read();
            }
    }
}
/*
Using Binary Writer Class the Contents are Written
Aspect Ratio set to : 1.25
Temp Directory is : C:\Temp