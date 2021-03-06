/*
 * C# Program to List Disk Drives
 */
using System;
using System.IO;
class Test
{
    public static void Main()
    {
        DriveInfo[] driverslist = DriveInfo.GetDrives();
        foreach (DriveInfo d in driverslist)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  File type: {0}", d.DriveType);
                if (d.IsReady == true)
                    {
                        Console.WriteLine(" Total size of drive:{0, 15} bytes ",d.TotalSize);
                        Console.Read();
                    }
            }
    }
}

/*
Drive C:\
File Type : Fixed
Total Size of Drive : 107268272128