/*
 * C# Program to Trap Events from File
 */
using System;
using System.IO;
class Test
{
    static void namechang(object sender, RenamedEventArgs evn)
    {
        Console.WriteLine("{0} NameChanged to {1}", evn.OldFullPath, evn.FullPath);
    }
    static void changed(object sender, FileSystemEventArgs evn)
    {
        Console.WriteLine(evn.FullPath + " " + evn.ChangeType);
    }
    static void Main(string[] arg)
    {
        FileSystemWatcher w = new FileSystemWatcher();
        w.Path = "d:\\srip";
        w.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName |NotifyFilters.LastAccess | NotifyFilters.LastWrite;
        w.Filter = "";
        w.Created += new FileSystemEventHandler(changed);
        w.Deleted += new FileSystemEventHandler(changed);
        w.Changed += new FileSystemEventHandler(changed);
        w.Renamed += new RenamedEventHandler(namechang);
        w.EnableRaisingEvents = true;
        Console.WriteLine("Press any key to quit");
        Console.Read();
    }
}

/*
Press any key to quit